using System;
using System.Collections.Generic;

namespace API.Models
{
    class Report
    {
        public float UserExperienceScore { 
            get; set;
        }

        public DateTime ReportingTime { 
            get; set;
        }

        public Dictionary<string, Effort> Impact {
            get; set;
        }

        public string PredictedBusinessStatus { 
            get; set;    
        }

        public void setPredictedBusinessStatus(float score) {
            if(score <= 4300) {
                this.PredictedBusinessStatus = "Safe to deploy";
            } else if(score >= 4300 && score <= 5800) {
                this.PredictedBusinessStatus = "Need to improve";
            } else {
                this.PredictedBusinessStatus = "Not recommended to deploy";
            }
        }

        public void setImpact(ModelInput model, float previousScore) {
            this.Impact = new Dictionary<string, Effort>();

            if(model.TimeToInteractive > 3800) {
                float reduction = model.TimeToInteractive - 3800;
                float total = model.TimeToInteractive;
                
                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.TimeToInteractive = model.TimeToInteractive - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;
                

                this.Impact.Add(
                    "timeToInteractive",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }

            if(model.ServerResponseTime > 600) {
                float reduction = model.ServerResponseTime - 600;
                float total = model.ServerResponseTime;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.ServerResponseTime = model.ServerResponseTime - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;

                this.Impact.Add(
                    "serverResponseTime",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }

            if(model.FirstCpuIdle > 4700) {
                float reduction = model.FirstCpuIdle - 4700;
                float total = model.FirstCpuIdle;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.FirstCpuIdle = model.FirstCpuIdle - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;

                this.Impact.Add(
                    "firstCpuIdle",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }

            if(model.BootUpTime > 2000) {
                float reduction = model.BootUpTime - 2000;
                float total = model.BootUpTime;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.BootUpTime = model.BootUpTime - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;

                this.Impact.Add(
                    "bootUpTime",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }


            // in KB
            if(model.TotalByteWeight / 1000 > 1600) {
                float reduction = (model.TotalByteWeight / 1000) - 1600;
                float total = model.TotalByteWeight / 1000;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.TotalByteWeight = model.TotalByteWeight - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;

                this.Impact.Add(
                    "totalByteWeight",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }

            if(model.LargestContentfulPaint > 2500) {
                float reduction = model.LargestContentfulPaint - 2500;
                float total = model.LargestContentfulPaint;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.LargestContentfulPaint = model.LargestContentfulPaint - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;

                this.Impact.Add(
                    "largestContentfulPaint",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }

            if(model.FirstMeaningfulPaint > 2000) {
                float reduction = model.FirstMeaningfulPaint - 2000;
                float total = model.FirstMeaningfulPaint;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.FirstMeaningfulPaint = model.FirstMeaningfulPaint - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;


                this.Impact.Add(
                    "firstMeaningfulPaint",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }

            if(model.TotalBlockingTime > 300) {
                float reduction = model.TotalBlockingTime - 300;
                float total = model.TotalBlockingTime;

                // Improvement Prediction After Reduction
                var newModel = model;
                newModel.TotalBlockingTime = model.TotalBlockingTime - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;

                this.Impact.Add(
                    "totalBlockingTime",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }

            if(model.FirstContentfulPaint > 2000) {
                float reduction = model.FirstContentfulPaint - 2000;
                float total = model.FirstContentfulPaint;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.FirstContentfulPaint = model.FirstContentfulPaint - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;

                this.Impact.Add(
                    "firstContentfulPaint",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }
        }
    }
}