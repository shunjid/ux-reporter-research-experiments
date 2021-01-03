using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

            if(model.CumulativeLayoutShift > 0.1) {
                float reduction = model.CumulativeLayoutShift - 0.1f;
                float total = model.CumulativeLayoutShift;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.CumulativeLayoutShift = model.CumulativeLayoutShift - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;

                this.Impact.Add(
                    "cumulativeLayoutShift",
                    new Effort {
                        suggestedReduction = reduction,
                        effortPercentage = (reduction / total) * 100,
                        predictedImprovement = improvement
                    }
                );
            }

            if(model.DomSize > 1500) {
                float reduction = model.DomSize - 1500;
                float total = model.DomSize;

                // Improvement Prediction Afte Reduction
                var newModel = model;
                newModel.DomSize = model.DomSize - reduction;
                var newPrediction = ConsumeModel.Predict(
                  input: newModel
                );
                var improvement = ((previousScore - newPrediction.Score) / previousScore) * 100;


                this.Impact.Add(
                    "domSize",
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
        }
    }
}