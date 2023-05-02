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

            }
        }
    }
}
