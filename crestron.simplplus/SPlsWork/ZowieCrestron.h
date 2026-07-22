namespace ZowieCrestron.Models.Recording;
        // class declarations
         class SetTaskInfoRequest;
         class SetTaskInfoData;
         class GetTaskListResponse;
         class RecordingFile;
         class TimeObject;
         class RecordingTask;
         class SetTaskEnableRequest;
         class SetTaskEnableData;
         class StorageDeviceInfo;
         class GetTaskSaveFilesRequest;
         class GetTaskSaveFilesData;
         class PageControl;
         class GetTaskListRequest;
         class PaginationControl;
         class GetTaskSaveFilesResponse;
         class SaveFilesData;
     class SetTaskInfoRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        SetTaskInfoData Data;
    };

     class SetTaskInfoData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Index[];
        STRING Name[];
        STRING FileNamePrefix[];
    };

     class GetTaskListResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Status[];
        STRING Rsp[];
    };

     class RecordingFile 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING TaskId[];
        STRING StartTime[];
        STRING EndTime[];
        STRING Filename[];
        STRING FileUrl[];
        SIGNED_LONG_INTEGER FileSize;
        SIGNED_LONG_INTEGER Duration;
        SIGNED_LONG_INTEGER CaseNum;
        TimeObject StartTimeObj;
        TimeObject EndTimeObj;
    };

     class TimeObject 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Year;
        SIGNED_LONG_INTEGER Month;
        SIGNED_LONG_INTEGER Day;
        SIGNED_LONG_INTEGER Hour;
        SIGNED_LONG_INTEGER Minute;
        SIGNED_LONG_INTEGER Second;
    };

     class RecordingTask 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Index[];
        STRING FileNamePrefix[];
        STRING Name[];
        SIGNED_LONG_INTEGER RecordFormat;
        SIGNED_LONG_INTEGER RecordMode;
        SIGNED_LONG_INTEGER RecordLoopMode;
        SIGNED_LONG_INTEGER LimitType;
        SIGNED_LONG_INTEGER SizeLimit;
        SIGNED_LONG_INTEGER TimeLimit;
        SIGNED_LONG_INTEGER Enable;
        SIGNED_LONG_INTEGER StorageId;
        SIGNED_LONG_INTEGER StreamId;
        SIGNED_LONG_INTEGER AudioStreamId;
        SIGNED_LONG_INTEGER Status;
        StorageDeviceInfo StorageInfo;
        STRING CurrentFileName[];
        SIGNED_LONG_INTEGER Duration;
    };

     class SetTaskEnableRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        SetTaskEnableData Data;
    };

     class SetTaskEnableData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Index[];
        SIGNED_LONG_INTEGER Enable;
    };

     class StorageDeviceInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        SIGNED_LONG_INTEGER Index;
        STRING MountPath[];
        SIGNED_LONG_INTEGER Status;
        SIGNED_LONG_INTEGER TotalSpace;
        SIGNED_LONG_INTEGER FreeSpace;
        SIGNED_LONG_INTEGER UsageSpace;
        SIGNED_LONG_INTEGER FileSystem;
    };

     class GetTaskSaveFilesRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        GetTaskSaveFilesData Data;
    };

     class GetTaskSaveFilesData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Index[];
        PageControl Control;
    };

     class PageControl 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER CurrentPage;
        SIGNED_LONG_INTEGER DefaultRecordNum;
    };

     class GetTaskListRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
    };

     class PaginationControl 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER FirstPage;
        SIGNED_LONG_INTEGER CurrentPage;
        SIGNED_LONG_INTEGER LastPage;
        SIGNED_LONG_INTEGER DefaultRecordNum;
        SIGNED_LONG_INTEGER Sum;
        SIGNED_LONG_INTEGER FrontPage;
        SIGNED_LONG_INTEGER NextPage;
    };

     class GetTaskSaveFilesResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Status[];
        STRING Rsp[];
        SaveFilesData Data;
    };

     class SaveFilesData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        StorageDeviceInfo StorageInfo;
        PaginationControl Control;
        SIGNED_LONG_INTEGER StorageFilesSize;
    };

namespace ZowieCrestron.Models.Ndi;
        // class declarations
         class NdiGetRecvConfigRequest;
         class NdiCloseRequest;
         class NdiGetAllResponse;
         class NdiGetRecvConfigResponse;
         class NdiRecvConfigData;
         class NdiSourceEntry;
         class NdiGetAllRequest;
         class NdiFindRequest;
         class NdiSetRecvConfigRequest;
         class NdiSetRecvConfigData;
         class NdiRecvRequest;
         class NdiRecvData;
           class StreamplayStatusCode;
     class NdiGetRecvConfigRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
    };

     class NdiCloseRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
    };

     class NdiGetAllResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Status[];
        STRING Rsp[];
    };

     class NdiGetRecvConfigResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Status[];
        STRING Rsp[];
        NdiRecvConfigData Data;
    };

     class NdiRecvConfigData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Groups[];
    };

     class NdiSourceEntry 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Index;
        STRING Name[];
        STRING Url[];
        StreamplayStatusCode StreamplayStatus;
        SIGNED_LONG_INTEGER Bandwidth;
        SIGNED_LONG_INTEGER Width;
        SIGNED_LONG_INTEGER Height;
    };

     class NdiGetAllRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
    };

     class NdiFindRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
    };

     class NdiSetRecvConfigRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        NdiSetRecvConfigData Data;
    };

     class NdiSetRecvConfigData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Groups[];
    };

     class NdiRecvRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        NdiRecvData Data;
    };

     class NdiRecvData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING NdiName[];
    };

namespace ZowieCrestron;
        // class declarations
         class ZowieApiClient;
         class ZowieMain;
         class ZowieApiConfig;
     class ZowieMain 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ( STRING baseUrl , STRING loginCheckFlag );
        INTEGER_FUNCTION StreamplayGetAll ();
        INTEGER_FUNCTION GetStreamplayCount ();
        STRING_FUNCTION GetStreamplayName ( INTEGER index );
        STRING_FUNCTION GetStreamplayUrl ( INTEGER index );
        INTEGER_FUNCTION GetStreamplaySwitch ( INTEGER index );
        INTEGER_FUNCTION GetStreamplayStreamType ( INTEGER index );
        INTEGER_FUNCTION GetStreamplayStatus ( INTEGER index );
        INTEGER_FUNCTION StreamplayAdd ( INTEGER switchId , STRING name , INTEGER streamType , STRING url );
        INTEGER_FUNCTION StreamplayDelete ( INTEGER index );
        INTEGER_FUNCTION StreamplayModify ( INTEGER index , INTEGER switchId , STRING name , INTEGER streamType , STRING url );
        INTEGER_FUNCTION StreamplaySwitchSource ( INTEGER switchId , INTEGER index );
        INTEGER_FUNCTION GetDecoderState ();
        INTEGER_FUNCTION NdiFind ();
        INTEGER_FUNCTION NdiGetAll ();
        INTEGER_FUNCTION GetNdiSourceCount ();
        STRING_FUNCTION GetNdiSourceName ( INTEGER index );
        STRING_FUNCTION GetNdiSourceUrl ( INTEGER index );
        INTEGER_FUNCTION GetNdiSourceStatus ( INTEGER index );
        INTEGER_FUNCTION NdiReceive ( STRING ndiName );
        INTEGER_FUNCTION NdiClose ();
        STRING_FUNCTION NdiGetRecvConfig ();
        INTEGER_FUNCTION NdiSetRecvConfig ( STRING groups );
        INTEGER_FUNCTION RecordGetTaskList ();
        INTEGER_FUNCTION GetRecordTaskCount ();
        STRING_FUNCTION GetRecordTaskName ( INTEGER index );
        STRING_FUNCTION GetRecordTaskIndex ( INTEGER index );
        INTEGER_FUNCTION GetRecordTaskStatus ( INTEGER index );
        INTEGER_FUNCTION GetRecordTaskEnable ( INTEGER index );
        STRING_FUNCTION GetRecordTaskCurrentFile ( INTEGER index );
        INTEGER_FUNCTION RecordSetTaskInfo ( STRING taskIndex , STRING name , STRING fileNamePrefix , INTEGER recordFormat , INTEGER recordMode , INTEGER loopMode , INTEGER limitType , INTEGER sizeLimit , INTEGER timeLimit , INTEGER storageId , INTEGER streamId );
        INTEGER_FUNCTION RecordSetTaskEnable ( STRING taskIndex , INTEGER enable );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace ZowieCrestron.Models.Decoding;
        // class declarations
         class StreamplaySwitchRequest;
         class StreamplaySwitchData;
         class StreamplayModifyRequest;
         class StreamplayModifyData;
         class GetDecoderStateRequest;
         class StreamplayAddRequest;
         class StreamplayAddData;
         class StreamplayEntry;
         class StreamplayStatusCode;
         class StreamplayDeleteRequest;
         class StreamplayDeleteData;
         class GetDecoderStateResponse;
         class DecoderStateData;
         class StreamplayGetAllResponse;
         class StreamplayGetAllRequest;
     class StreamplaySwitchRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        StreamplaySwitchData Data;
    };

     class StreamplaySwitchData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Switch;
        SIGNED_LONG_INTEGER Index;
    };

     class StreamplayModifyRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        StreamplayModifyData Data;
    };

     class StreamplayModifyData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Index;
        STRING Name[];
        STRING Url[];
    };

     class GetDecoderStateRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
    };

     class StreamplayAddRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        StreamplayAddData Data;
    };

     class StreamplayAddData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Switch;
        STRING Name[];
        SIGNED_LONG_INTEGER StreamType;
        STRING Url[];
    };

     class StreamplayEntry 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Index;
        SIGNED_LONG_INTEGER Switch;
        STRING Name[];
        SIGNED_LONG_INTEGER StreamType;
        STRING Url[];
        StreamplayStatusCode StreamplayStatus;
        SIGNED_LONG_INTEGER Bandwidth;
        SIGNED_LONG_INTEGER Width;
        SIGNED_LONG_INTEGER Height;
    };

    static class StreamplayStatusCode // enum
    {
        static SIGNED_LONG_INTEGER NotTurnedOn;
        static SIGNED_LONG_INTEGER PullingStream;
        static SIGNED_LONG_INTEGER PullingStreamStopped;
        static SIGNED_LONG_INTEGER PullingStreamNoVideo;
        static SIGNED_LONG_INTEGER PullingStreamVideoFormatUnsupported;
        static SIGNED_LONG_INTEGER PullingStreamNoAudio;
        static SIGNED_LONG_INTEGER PullingStreamAudioFormatUnsupported;
    };

     class StreamplayDeleteRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
        StreamplayDeleteData Data;
    };

     class StreamplayDeleteData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Index;
    };

     class GetDecoderStateResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Status[];
        STRING Rsp[];
        DecoderStateData Data;
    };

     class DecoderStateData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER DecoderState;
    };

     class StreamplayGetAllResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Status[];
        STRING Rsp[];
    };

     class StreamplayGetAllRequest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Option[];
        STRING Group[];
        STRING Opt[];
    };

namespace ZowieCrestron.Models;
        // class declarations
         class ZowieConstants;
         class StorageIndex;
         class RecordEnable;
         class RecordFormat;
         class RecordMode;
         class LimitType;
         class SizeLimit;
         class TimeLimit;
         class StreamType;
         class SuccessResponse;
    static class ZowieConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class StorageIndex 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Usb1[];
        static STRING SdCard[];
        static STRING Nas1[];

        // class properties
    };

    static class RecordEnable 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER Pause;
        static SIGNED_LONG_INTEGER Continue;

        // class properties
    };

    static class RecordFormat 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER Mp4;
        static SIGNED_LONG_INTEGER Ts;
        static SIGNED_LONG_INTEGER Mov;

        // class properties
    };

    static class RecordMode 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER Manual;
        static SIGNED_LONG_INTEGER AutoStart;

        // class properties
    };

    static class LimitType 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER SizeSplit;
        static SIGNED_LONG_INTEGER TimeSplit;

        // class properties
    };

    static class SizeLimit 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER OnePointFiveGb;
        static SIGNED_LONG_INTEGER ThreeGb;
        static SIGNED_LONG_INTEGER FourGb;

        // class properties
    };

    static class TimeLimit 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER FifteenMin;
        static SIGNED_LONG_INTEGER ThirtyMin;
        static SIGNED_LONG_INTEGER FortyFiveMin;

        // class properties
    };

    static class StreamType 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER Local;
        static SIGNED_LONG_INTEGER Live;

        // class properties
    };

     class SuccessResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Status[];
        STRING Rsp[];
    };

