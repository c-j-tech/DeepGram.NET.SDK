using System;

namespace CJTECH.DeepGram.NET.SDK.Models.Transcription
{
    public class Metadata
    {
        public string TransactionKey { get; set; }
        public string RequestId { get; set; }
        public string SHA256 { get; set; }
        public DateTime Created { get; set; }
        public float Duration { get; set; }
        public int Channels { get; set; }
        public string[] Models { get; set; }
    }

}
