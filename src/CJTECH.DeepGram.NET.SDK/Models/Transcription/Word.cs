using System.Text.Json.Serialization;

namespace CJTECH.DeepGram.NET.SDK.Models.Transcription
{
    public class Word
    {
        [JsonPropertyName("word")]
        public string Text { get; set; }
        public float Start { get; set; }
        public float End { get; set; }
        public float Confidence { get; set; }
    }

}
