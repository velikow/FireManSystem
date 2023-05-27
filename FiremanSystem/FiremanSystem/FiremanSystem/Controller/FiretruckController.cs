using FiremanSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiremanSystem.Controller
{
    internal class FiretruckController
    {
        internal void CreateFiretruck(Firetruck firetruck)
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                var lastFiretruck = db.Firetrucks.ToList().LastOrDefault();
                if (lastFiretruck == null)
                {
                    firetruck.Id = 1;
                }
                else
                {
                    firetruck.Id = lastFiretruck.Id + 1;
                }
                db.Firetrucks.Add(firetruck);
                db.SaveChanges();
            }
        }
        internal List<Firetruck> ReadAllTrucks()
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                return db.Firetrucks.ToList();
            }
        }

        public void UpdateFiretruck(int id, Firetruck firetruck)

        {

            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                var firetruckToUpdate = db.Firetrucks.Where(u => u.Id == id).FirstOrDefault();
                if (firetruckToUpdate != null)
                {
                    firetruckToUpdate.Id = id;
                    db.SaveChanges();
                }
            }
        }


        public void DeleteFiretruck(int id)
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                var firetruckToDelete = db.Firetrucks.Where(u => u.Id == id).FirstOrDefault();
                if (firetruckToDelete != null)
                {
                    db.Firetrucks.Remove(firetruckToDelete);
                    db.SaveChanges();
                }
            }
        }

    }
}
