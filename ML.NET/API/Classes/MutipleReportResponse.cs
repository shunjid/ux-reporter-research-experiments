using System.Collections.Generic;
using API.Models;

namespace API.Classes
{ 
   class MultipleReportResponse
   {
       public string Status { get; set; }

       public List<Report> Reports { get; set; }
   }  
}