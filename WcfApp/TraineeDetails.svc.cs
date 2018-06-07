using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfApp
{
    public class Service1 : TraineeDetails
    {
        public static List<Trainees> trainees = new List<Trainees>()
        {
            new Trainees {TraineeId=1,Name="Pravanya",Age=26,DOB=new DateTime(1991,8,14) },
            new Trainees {TraineeId=2,Name="Pavani",Age=25,DOB=new DateTime(1992,10,14) }
        };
        public List<Trainees> AddTraniee(Trainees addNewTrainee)
        {
            trainees.Add(addNewTrainee);
            return trainees;
        }
        public List<Trainees> DeleteTrainee(int deletedTraineeId)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == deletedTraineeId);
            trainees.Remove(deletingTrainee);
            return trainees;
        }
        public List<Trainees> GetTrainee()
        {
            return trainees;
        }
        public List<Trainees> UpdateTrainee(Trainees updatedTrainee)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == updatedTrainee.TraineeId);
            if (deletingTrainee == null)
                trainees.Add(updatedTrainee);
            else
            {
                trainees.Remove(deletingTrainee);
                trainees.Add(updatedTrainee);
            }
            return trainees;
        }
    }
}
