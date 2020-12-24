//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace PredictLcp.Model
{
    public class ModelInput
    {
        [ColumnName("FirstContentfulPaint"), LoadColumn(0)]
        public float FirstContentfulPaint { get; set; }


        [ColumnName("TimeToInteract"), LoadColumn(1)]
        public float TimeToInteract { get; set; }


        [ColumnName("ServerResponseTime"), LoadColumn(2)]
        public float ServerResponseTime { get; set; }


        [ColumnName("DomSize"), LoadColumn(3)]
        public float DomSize { get; set; }


        [ColumnName("BootUpTime"), LoadColumn(4)]
        public float BootUpTime { get; set; }


        [ColumnName("FirstMeaningfulPaint"), LoadColumn(5)]
        public float FirstMeaningfulPaint { get; set; }


        [ColumnName("TotalBlockingTime"), LoadColumn(6)]
        public float TotalBlockingTime { get; set; }


        [ColumnName("TotalByteWeight"), LoadColumn(7)]
        public float TotalByteWeight { get; set; }


        [ColumnName("FirstCpuIdle"), LoadColumn(8)]
        public float FirstCpuIdle { get; set; }


        [ColumnName("CumulativeLayoutShift"), LoadColumn(9)]
        public float CumulativeLayoutShift { get; set; }


        [ColumnName("LargestContentfulPaint"), LoadColumn(10)]
        public float LargestContentfulPaint { get; set; }


        [ColumnName("LcpCategory"), LoadColumn(11)]
        public string LcpCategory { get; set; }


    }
}
