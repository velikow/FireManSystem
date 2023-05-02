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
        internal List<Firetruck> ReadAllTrcuks()
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                return db.Firetrucks.ToList();
            }
        }

        public void UpdateTrucks(int id, Firetruck firetruck)
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {

            }
        }
    }
}
