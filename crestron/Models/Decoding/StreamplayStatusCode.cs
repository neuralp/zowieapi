namespace ZowieCrestron.Models.Decoding
{
    public enum StreamplayStatusCode
    {
        NotTurnedOn = 0,
        PullingStream = 1,
        PullingStreamStopped = 2,
        PullingStreamNoVideo = 3,
        PullingStreamVideoFormatUnsupported = 4,
        PullingStreamNoAudio = 5,
        PullingStreamAudioFormatUnsupported = 6
    }
}
