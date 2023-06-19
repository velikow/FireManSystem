using FiremanSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiremanSystem.Controller
{
    class AccidentsParticipantsController
    {
        internal void CreateAccident(AccidentsParticipants accident)
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var lastAccident = db.AccidentsParticipants.ToList().LastOrDefault();
                db.AccidentsParticipants.Add(accident);
                db.SaveChanges();
            }
        }
        internal List<AccidentsParticipants> ReadAllAccidents()
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                return db.AccidentsParticipants.ToList();
            }
        }

        public void UpdateAccident(AccidentsParticipants accident, int Accidentsid,int ParticipantsId )

        {

            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var accidentToUpdate = db.AccidentsParticipants.Where(u => u.AccidentsId == Accidentsid && u.ParticipantsId == ParticipantsId ).FirstOrDefault();
                if (accidentToUpdate != null)
                {
                    accidentToUpdate.AccidentsId= accident.AccidentsId;
                    accidentToUpdate.ParticipantsId= accident.ParticipantsId;
                    db.SaveChanges();
                }
            }
        }


        public void DeleteAccident(int id)
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var accidentToDelete = db.Accidents.Where(u => u.Id == id).FirstOrDefault();
                if (accidentToDelete != null)
                {
                    db.Accidents.Remove(accidentToDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}
