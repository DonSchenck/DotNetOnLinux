using Speakr.Models;

namespace Speakr
{
   public class PerformanceExample {
       public static void AddALot() {
           using (var db = new SubmissionContext())
           {
               // Put a loop here and add a ton of records to see the performance
               // db.SaveChanges();
           }
       }
   }
   
}
