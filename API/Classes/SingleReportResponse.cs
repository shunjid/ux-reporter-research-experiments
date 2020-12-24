using API.Models;

namespace API.Classes
{ 
   class SingleReportResponse
   {
       public string Status { get; set; }

       public Report Report { get; set; }
   }
}