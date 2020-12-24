using System;
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
    }
}