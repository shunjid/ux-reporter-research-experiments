using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.ML.Data;

namespace API.Models
{
    public class ModelInput
    {
        [ColumnName("FirstContentfulPaint"), LoadColumn(0)]
        public float FirstContentfulPaint { get; set; }


        [ColumnName("TimeToInteractive"), LoadColumn(1)]
        public float TimeToInteractive { get; set; }


        [ColumnName("ServerResponseTime"), LoadColumn(2)]
        public float ServerResponseTime { get; set; }


        [ColumnName("DOMSize"), LoadColumn(3)]
        public float DomSize { get; set; }


        [ColumnName("TotalBlockingTime"), LoadColumn(4)]
        public float TotalBlockingTime { get; set; }


        [ColumnName("TotalByteWeight"), LoadColumn(5)]
        public float TotalByteWeight { get; set; }


        [ColumnName("CumulativeLayoutShift"), LoadColumn(6)]
        public float CumulativeLayoutShift { get; set; }


        [ColumnName("LargestContentfulPaint"), LoadColumn(7)]
        public float LargestContentfulPaint { get; set; }


        [ColumnName("UserExperience"), LoadColumn(8)]
        public float UserExperience { get; set; }

    }
}
