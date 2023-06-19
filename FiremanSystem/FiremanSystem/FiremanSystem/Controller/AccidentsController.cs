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
        internal void CreateAccident(Accidents accident)
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
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
        internal List<Accidents> ReadAllAccidents()
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                return db.Accidents.ToList();
            }
        }

        public void UpdateAccident(int id, Accidents accident)

        {

            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var accidentToUpdate = db.Accidents.Where(u => u.Id == id).FirstOrDefault();
                if (accidentToUpdate != null)
                {
                    accidentToUpdate.Name= accident.Name;
                    accidentToUpdate.Day= accident.Day;
                    accidentToUpdate.Id = id;
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
