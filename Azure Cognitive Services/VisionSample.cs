using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AzureDemos.CognitiveServices
{
    public class VisionSample
    {
        private static string subscriptionKey = "YOUR_KEY";
        private static string endpoint = "YOUR_ENDPOINT";

        public async Task AnalyzeImageAsync(string imagePath)
        {
            ComputerVisionClient client = new ComputerVisionClient(new ApiKeyServiceClientCredentials(subscriptionKey))
            {
                Endpoint = endpoint
            };

            List<VisualFeatureTypes?> features = new List<VisualFeatureTypes?>()
            {
                VisualFeatureTypes.Description,
                VisualFeatureTypes.Tags,
                VisualFeatureTypes.Objects
            };

            using (Stream imageStream = File.OpenRead(imagePath))
            {
                ImageAnalysis analysis = await client.AnalyzeImageInStreamAsync(imageStream, features);
                
                Console.WriteLine("Image Description:");
                foreach (var caption in analysis.Description.Captions)
                {
                    Console.WriteLine($"{caption.Text} with confidence {caption.Confidence}");
                }
            }
        }
    }
}
