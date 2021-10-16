namespace CJTECH.DeepGram.NET.SDK.Models.Transcription
{
    public class Alternative
    {
        public string Transcript { get; set; }
        public float Confidence { get; set; }
        public Word[] Words { get; set; }
    }

}
