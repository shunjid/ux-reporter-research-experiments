var axios = require("axios");
var data = JSON.stringify([
  {
    firstContentfulPaint: 2300,
    timeToInteractive: 3800,
    serverResponseTime: 303.494,
    domSize: 3195,
    totalBlockingTime: 1600,
    totalByteWeight: 2560395,
    cumulativeLayoutShift: 0.1598989464,
    largestContentfulPaint: 200,
  },
  {
    firstContentfulPaint: 854.5,
    timeToInteractive: 4798,
    serverResponseTime: 303.494,
    domSize: 3195,
    totalBlockingTime: 1600,
    totalByteWeight: 2560395,
    cumulativeLayoutShift: 0.06,
    largestContentfulPaint: 3244,
  },
]);

var config = {
  method: "post",
  url: "https://uxability-api.herokuapp.com/api/reports/",
  headers: {
    "Content-Type": "application/json",
  },
  data: data,
};

axios(config)
  .then(function (response) {
    var reports = response.data.reports;

    reports.forEach((eachReport) => {
      console.table(eachReport.impact);
    });
  })
  .catch(function (error) {
    console.log(error);
  });
