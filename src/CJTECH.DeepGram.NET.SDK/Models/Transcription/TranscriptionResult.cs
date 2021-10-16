using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CJTECH.DeepGram.NET.SDK.Models.Transcription
{ 
    public class TranscriptionResult
    {
    
        public Metadata Metadata { get; set; }
        public Results Results { get; set; }
    } 
}
