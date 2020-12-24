using System;
using Custom.Model;

namespace Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelInput sampleData = new ModelInput()
            {
                FirstContentfulPaint = 810F,
                TimeToInteract = 1623.0004F,
                ServerResponseTime = 148.574F,
                BootUpTime = 95.844F,
                FirstMeaningfulPaint = 810F,
                TotalBlockingTime = 1F,
                TotalByteWeight = 964194F,
                FirstCpuIdle = 1582F,
                LargestContentfulPaint = 890F,
            };

            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual UserExperience with predicted UserExperience from sample data...\n\n");
            Console.WriteLine($"FirstContentfulPaint: {sampleData.FirstContentfulPaint}");
            Console.WriteLine($"TimeToInteract: {sampleData.TimeToInteract}");
            Console.WriteLine($"ServerResponseTime: {sampleData.ServerResponseTime}");
            Console.WriteLine($"BootUpTime: {sampleData.BootUpTime}");
            Console.WriteLine($"FirstMeaningfulPaint: {sampleData.FirstMeaningfulPaint}");
            Console.WriteLine($"TotalBlockingTime: {sampleData.TotalBlockingTime}");
            Console.WriteLine($"TotalByteWeight: {sampleData.TotalByteWeight}");
            Console.WriteLine($"FirstCpuIdle: {sampleData.FirstCpuIdle}");
            Console.WriteLine($"LargestContentfulPaint: {sampleData.LargestContentfulPaint}");
            Console.WriteLine($"\n\nPredicted UserExperience: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
