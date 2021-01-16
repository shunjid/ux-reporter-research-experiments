using System;
using System.Collections.Generic;
using API.Classes;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [Route("api/reports")]
    [ApiController]
    public class ReportsV1_0Controller : ControllerBase
    {
        [HttpPost]
        public IActionResult Index([FromBody] List<ModelInput> modelInputs) {
            var reports = new List<Report>();

            modelInputs.ForEach(eachModelInput => {
                var predictionResult = ConsumeModel.Predict(
                    input: eachModelInput
                );

                var report = new Report {
                    ReportingTime = DateTime.UtcNow,
                    UserExperienceScore = predictionResult.Score
                };

                report.setPredictedBusinessStatus(predictionResult.Score);
                report.setImpact(eachModelInput, predictionResult.Score);

                reports.Add(report);
            });

            return Ok(new MultipleReportResponse{
                Status = "ok",
                Reports = reports
            });
        }

        [HttpPost("findByIssue")]
        public IActionResult FindOne([FromBody] ModelInput modelInput) {
            var predictionResult = ConsumeModel.Predict(
                input: modelInput
            );

            var report = new Report {
                ReportingTime = DateTime.Today,
                UserExperienceScore = predictionResult.Score
            };

            report.setPredictedBusinessStatus(predictionResult.Score);
            report.setImpact(modelInput, predictionResult.Score);
            
            return Ok(new SingleReportResponse{
                Status = "ok",
                Report = report
            });
        }
    }
}