//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace RandomForest.Model
{
    public class ModelInput
    {
        [ColumnName("FirstContentfulPaint"), LoadColumn(0)]
        public float FirstContentfulPaint { get; set; }


        [ColumnName("TimeToInteractive"), LoadColumn(1)]
        public float TimeToInteractive { get; set; }


        [ColumnName("ServerResponseTime"), LoadColumn(2)]
        public float ServerResponseTime { get; set; }


        [ColumnName("BootUpTime"), LoadColumn(3)]
        public float BootUpTime { get; set; }


        [ColumnName("FirstMeaningfulPaint"), LoadColumn(4)]
        public float FirstMeaningfulPaint { get; set; }


        [ColumnName("TotalBlockingTime"), LoadColumn(5)]
        public float TotalBlockingTime { get; set; }


        [ColumnName("TotalByteWeight"), LoadColumn(6)]
        public float TotalByteWeight { get; set; }


        [ColumnName("FirstCpuIdle"), LoadColumn(7)]
        public float FirstCpuIdle { get; set; }


        [ColumnName("LargestContentfulPaint"), LoadColumn(8)]
        public float LargestContentfulPaint { get; set; }


        [ColumnName("UserExperience"), LoadColumn(9)]
        public float UserExperience { get; set; }


    }
}
