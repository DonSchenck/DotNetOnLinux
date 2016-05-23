using Speakr.Models;

namespace Speakr
{
   public class PerformanceExample {
       public static void AddALot() {
           using (var db = new SubmissionContext())
           {
               db.Submissions.Add(new Submission { ConferenceName="Test add a lot", SessionTitle="Added en masse"});
               db.Submissions.Add(new Submission { ConferenceName="Test add a lot", SessionTitle="Added en masse 2"});
               db.Submissions.Add(new Submission { ConferenceName="Test add a lot", SessionTitle="Added en masse 3"});
               db.Submissions.Add(new Submission { ConferenceName="Test add a lot", SessionTitle="Added en masse 4"});
               db.Submissions.Add(new Submission { ConferenceName="Test add a lot", SessionTitle="Added en masse 5"});
               db.Submissions.Add(new Submission { ConferenceName="Test add a lot", SessionTitle="Added en masse 6"});
               db.Submissions.Add(new Submission { ConferenceName="Test add a lot", SessionTitle="Added en masse 7"});
               db.Submissions.Add(new Submission { ConferenceName="Test add a lot", SessionTitle="Added en masse 8"});
               
               db.SaveChanges();
           }
       }
   }
   
}