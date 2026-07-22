using System;
using System.Collections.Generic;
using ZowieCrestron.Models;
using ZowieCrestron.Models.Decoding;
using ZowieCrestron.Models.Ndi;
using ZowieCrestron.Models.Recording;

namespace ZowieCrestron
{
    public class ZowieMain
    {
        private ZowieApiClient _client;
        private List<StreamplayEntry> _streamplayEntries;
        private List<NdiSourceEntry> _ndiSources;
        private List<RecordingTask> _recordingTasks;

        public ZowieMain() { }

        public void Initialize(string baseUrl, string loginCheckFlag)
        {
            if (_client != null)
            {
                _client.Dispose();
                _client = null;
            }
            var config = new ZowieApiConfig(baseUrl, loginCheckFlag);
            _client = new ZowieApiClient(config);
        }

        // ── Streamplay ────────────────────────────────────────────────────────────

        public ushort StreamplayGetAll()
        {
            if (_client == null) return 0;
            try
            {
                var response = _client.PostStreamplay<StreamplayGetAllRequest, StreamplayGetAllResponse>(
                    new StreamplayGetAllRequest());

                if (response == null)
                {
                    Console.WriteLine("[ZowieMain] StreamplayGetAll: response is null");
                    return 0;
                }

                Console.WriteLine("[ZowieMain] StreamplayGetAll: status=\"{0}\" isSuccess={1} entryCount={2}",
                    response.Status, response.IsSuccess, response.Streamplay != null ? response.Streamplay.Count : -1);

                if (!response.IsSuccess) return 0;
                _streamplayEntries = response.Streamplay ?? new List<StreamplayEntry>();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ZowieMain] StreamplayGetAll exception: {0}", ex.Message);
                return 0;
            }
        }

        public ushort GetStreamplayCount()
        {
            return _streamplayEntries != null ? (ushort)_streamplayEntries.Count : (ushort)0;
        }

        public string GetStreamplayName(ushort index)
        {
            if (_streamplayEntries == null || index >= _streamplayEntries.Count) return string.Empty;

            Console.WriteLine("[ZowieMain] Streamplay entries ({0} total):", _streamplayEntries.Count);
            for (int i = 0; i < _streamplayEntries.Count; i++)
            {
                var e = _streamplayEntries[i];
                Console.WriteLine("  [{0}] Name={1} | Url={2} | Switch={3} | StreamType={4} | Status={5}",
                    i, e.Name, e.Url, e.Switch, e.StreamType, e.StreamplayStatus);
            }

            return _streamplayEntries[index].Name ?? string.Empty;
        }

        public string GetStreamplayUrl(ushort index)
        {
            if (_streamplayEntries == null || index >= _streamplayEntries.Count) return string.Empty;
            return _streamplayEntries[index].Url ?? string.Empty;
        }

        public ushort GetStreamplaySwitch(ushort index)
        {
            if (_streamplayEntries == null || index >= _streamplayEntries.Count) return 0;
            return (ushort)_streamplayEntries[index].Switch;
        }

        public ushort GetStreamplayStreamType(ushort index)
        {
            if (_streamplayEntries == null || index >= _streamplayEntries.Count) return 0;
            return (ushort)_streamplayEntries[index].StreamType;
        }

        public ushort GetStreamplayStatus(ushort index)
        {
            if (_streamplayEntries == null || index >= _streamplayEntries.Count) return 0;
            return (ushort)_streamplayEntries[index].StreamplayStatus;
        }

        public ushort StreamplayAdd(ushort switchId, string name, ushort streamType, string url)
        {
            if (_client == null) return 0;
            try
            {
                var request = new StreamplayAddRequest
                {
                    Data = new StreamplayAddRequest.StreamplayAddData
                    {
                        Switch = switchId,
                        Name = name,
                        StreamType = streamType,
                        Url = url
                    }
                };
                var response = _client.PostStreamplay<StreamplayAddRequest, SuccessResponse>(request);
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        public ushort StreamplayDelete(ushort index)
        {
            if (_client == null) return 0;
            try
            {
                var request = new StreamplayDeleteRequest
                {
                    Data = new StreamplayDeleteRequest.StreamplayDeleteData { Index = index }
                };
                var response = _client.PostStreamplay<StreamplayDeleteRequest, SuccessResponse>(request);
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        // Pass ushort.MaxValue (65535) for numeric params or empty string for string params to leave them unchanged.
        public ushort StreamplayModify(ushort index, ushort switchId, string name, ushort streamType, string url)
        {
            if (_client == null) return 0;
            try
            {
                var data = new StreamplayModifyRequest.StreamplayModifyData { Index = index };
                if (switchId != ushort.MaxValue) data.Switch = switchId;
                if (!string.IsNullOrEmpty(name)) data.Name = name;
                if (streamType != ushort.MaxValue) data.StreamType = streamType;
                if (!string.IsNullOrEmpty(url)) data.Url = url;

                var request = new StreamplayModifyRequest { Data = data };
                var response = _client.PostStreamplay<StreamplayModifyRequest, SuccessResponse>(request);
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        public ushort StreamplaySwitchSource(ushort switchId, ushort index)
        {
            if (_client == null) return 0;
            try
            {
                var request = new StreamplaySwitchRequest
                {
                    Data = new StreamplaySwitchRequest.StreamplaySwitchData
                    {
                        Switch = switchId,
                        Index = index
                    }
                };
                var response = _client.PostStreamplay<StreamplaySwitchRequest, SuccessResponse>(request);
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        // Returns decoder state value, or ushort.MaxValue on error.
        public ushort GetDecoderState()
        {
            if (_client == null) return ushort.MaxValue;
            try
            {
                var response = _client.PostStreamplay<GetDecoderStateRequest, GetDecoderStateResponse>(
                    new GetDecoderStateRequest());
                if (response == null || !response.IsSuccess || response.Data == null) return ushort.MaxValue;
                return (ushort)response.Data.DecoderState;
            }
            catch { return ushort.MaxValue; }
        }

        // ── NDI ───────────────────────────────────────────────────────────────────

        public ushort NdiFind()
        {
            if (_client == null) return 0;
            try
            {
                var response = _client.PostStreamplay<NdiFindRequest, SuccessResponse>(new NdiFindRequest());
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        public ushort NdiGetAll()
        {
            if (_client == null) return 0;
            try
            {
                var response = _client.PostStreamplay<NdiGetAllRequest, NdiGetAllResponse>(new NdiGetAllRequest());
                if (response == null || !response.IsSuccess) return 0;
                _ndiSources = response.Data ?? new List<NdiSourceEntry>();
                return 1;
            }
            catch { return 0; }
        }

        public ushort GetNdiSourceCount()
        {
            return _ndiSources != null ? (ushort)_ndiSources.Count : (ushort)0;
        }

        public string GetNdiSourceName(ushort index)
        {
            if (_ndiSources == null || index >= _ndiSources.Count) return string.Empty;
            return _ndiSources[index].Name ?? string.Empty;
        }

        public string GetNdiSourceUrl(ushort index)
        {
            if (_ndiSources == null || index >= _ndiSources.Count) return string.Empty;
            return _ndiSources[index].Url ?? string.Empty;
        }

        public ushort GetNdiSourceStatus(ushort index)
        {
            if (_ndiSources == null || index >= _ndiSources.Count) return 0;
            return (ushort)_ndiSources[index].StreamplayStatus;
        }

        public ushort NdiReceive(string ndiName)
        {
            if (_client == null) return 0;
            try
            {
                var request = new NdiRecvRequest
                {
                    Data = new NdiRecvRequest.NdiRecvData { NdiName = ndiName }
                };
                var response = _client.PostStreamplay<NdiRecvRequest, SuccessResponse>(request);
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        public ushort NdiClose()
        {
            if (_client == null) return 0;
            try
            {
                var response = _client.PostStreamplay<NdiCloseRequest, SuccessResponse>(new NdiCloseRequest());
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        // Returns the NDI receive groups string, or empty on error.
        public string NdiGetRecvConfig()
        {
            if (_client == null) return string.Empty;
            try
            {
                var response = _client.PostStreamplay<NdiGetRecvConfigRequest, NdiGetRecvConfigResponse>(
                    new NdiGetRecvConfigRequest());
                if (response == null || !response.IsSuccess || response.Data == null) return string.Empty;
                return response.Data.Groups ?? string.Empty;
            }
            catch { return string.Empty; }
        }

        public ushort NdiSetRecvConfig(string groups)
        {
            if (_client == null) return 0;
            try
            {
                var request = new NdiSetRecvConfigRequest
                {
                    Data = new NdiSetRecvConfigRequest.NdiSetRecvConfigData { Groups = groups }
                };
                var response = _client.PostStreamplay<NdiSetRecvConfigRequest, SuccessResponse>(request);
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        // ── Recording ─────────────────────────────────────────────────────────────

        public ushort RecordGetTaskList()
        {
            if (_client == null) return 0;
            try
            {
                var response = _client.PostRecord<GetTaskListRequest, GetTaskListResponse>(
                    new GetTaskListRequest());
                if (response == null || !response.IsSuccess) return 0;
                _recordingTasks = response.Data ?? new List<RecordingTask>();
                return 1;
            }
            catch { return 0; }
        }

        public ushort GetRecordTaskCount()
        {
            return _recordingTasks != null ? (ushort)_recordingTasks.Count : (ushort)0;
        }

        public string GetRecordTaskName(ushort index)
        {
            if (_recordingTasks == null || index >= _recordingTasks.Count) return string.Empty;
            return _recordingTasks[index].Name ?? string.Empty;
        }

        public string GetRecordTaskIndex(ushort index)
        {
            if (_recordingTasks == null || index >= _recordingTasks.Count) return string.Empty;
            return _recordingTasks[index].Index ?? string.Empty;
        }

        public ushort GetRecordTaskStatus(ushort index)
        {
            if (_recordingTasks == null || index >= _recordingTasks.Count) return 0;
            return (ushort)_recordingTasks[index].Status;
        }

        public ushort GetRecordTaskEnable(ushort index)
        {
            if (_recordingTasks == null || index >= _recordingTasks.Count) return 0;
            return (ushort)_recordingTasks[index].Enable;
        }

        public string GetRecordTaskCurrentFile(ushort index)
        {
            if (_recordingTasks == null || index >= _recordingTasks.Count) return string.Empty;
            return _recordingTasks[index].CurrentFileName ?? string.Empty;
        }

        // Pass ushort.MaxValue (65535) for numeric params or empty string for string params to leave them unchanged.
        public ushort RecordSetTaskInfo(
            string taskIndex, string name, string fileNamePrefix,
            ushort recordFormat, ushort recordMode, ushort loopMode,
            ushort limitType, ushort sizeLimit, ushort timeLimit,
            ushort storageId, ushort streamId)
        {
            if (_client == null) return 0;
            try
            {
                var data = new SetTaskInfoRequest.SetTaskInfoData { Index = taskIndex };
                if (!string.IsNullOrEmpty(name)) data.Name = name;
                if (!string.IsNullOrEmpty(fileNamePrefix)) data.FileNamePrefix = fileNamePrefix;
                if (recordFormat != ushort.MaxValue) data.RecordFormat = recordFormat;
                if (recordMode != ushort.MaxValue) data.RecordMode = recordMode;
                if (loopMode != ushort.MaxValue) data.RecordLoopMode = loopMode;
                if (limitType != ushort.MaxValue) data.LimitType = limitType;
                if (sizeLimit != ushort.MaxValue) data.SizeLimit = sizeLimit;
                if (timeLimit != ushort.MaxValue) data.TimeLimit = timeLimit;
                if (storageId != ushort.MaxValue) data.StorageId = storageId;
                if (streamId != ushort.MaxValue) data.StreamId = streamId;

                var request = new SetTaskInfoRequest { Data = data };
                var response = _client.PostRecord<SetTaskInfoRequest, SuccessResponse>(request);
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }

        public ushort RecordSetTaskEnable(string taskIndex, ushort enable)
        {
            if (_client == null) return 0;
            try
            {
                var request = new SetTaskEnableRequest
                {
                    Data = new SetTaskEnableRequest.SetTaskEnableData
                    {
                        Index = taskIndex,
                        Enable = enable
                    }
                };
                var response = _client.PostRecord<SetTaskEnableRequest, SuccessResponse>(request);
                return (response != null && response.IsSuccess) ? (ushort)1 : (ushort)0;
            }
            catch { return 0; }
        }
    }
}
