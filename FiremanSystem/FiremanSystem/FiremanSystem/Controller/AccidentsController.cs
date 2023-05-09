using FiremanSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiremanSystem.Controller
{
    internal class AccidentsController
    {
        internal void CreateAccident(Accident accident)
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                var lastAccident = db.Accidents.ToList().LastOrDefault();
                if (lastAccident == null)
                {
                    accident.Id = 1;
                }
                else
                {
                    accident.Id = lastAccident.Id + 1;
                }
                db.Accidents.Add(accident);
                db.SaveChanges();
            }
        }
        internal List<Accident> ReadAllAccidents()
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                return db.Accidents.ToList();
            }
        }

        public void UpdateAccident(int id, Accident accident)

        {

            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                var accidentToUpdate = db.Accidents.Where(u => u.Id == id).FirstOrDefault();
                if (accidentToUpdate != null)
                {
                    accidentToUpdate.Name= accident.Name;
                    accidentToUpdate.Date= accident.Date;
                    accidentToUpdate.Id = id;
                    db.SaveChanges();
                }
            }
        }


        public void DeleteAccident(int id)
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
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
