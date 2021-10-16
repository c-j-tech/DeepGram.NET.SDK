using CJTECH.DeepGram.NET.SDK.Models.Transcription;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJTECH.DeepGram.NET.SDK
{
    public class Transcription
    {
        public async Task<TranscriptionResult> TranscribeRemoteFileAsync(string apiKey, string urlOrFilenameToTranscribe, string endpoint)
        {
            var transcription = await endpoint

                .WithHeader("Authorization", $"Token {apiKey}")
                .WithHeader("Content-Type", "application/json")
                .PostJsonAsync(new { url = urlOrFilenameToTranscribe })
                .ReceiveJson<TranscriptionResult>();

            return transcription;
        }
    }
}
