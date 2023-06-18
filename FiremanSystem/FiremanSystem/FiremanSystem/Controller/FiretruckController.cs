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
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var lastFiretruck = db.Firetruck.ToList().LastOrDefault();
                if (lastFiretruck == null)
                {
                    firetruck.Id = 1;
                }
                else
                {
                    firetruck.Id = lastFiretruck.Id + 1;
                }
                db.Firetruck.Add(firetruck);
                db.SaveChanges();
            }
        }
        internal List<Firetruck> ReadAllTrucks(bool Monday,bool Tuesday,bool Wednesday,bool Thursday,bool Firday,bool Saturday,bool Sunday)
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                List<Firetruck> fireturcks = new List<Firetruck>();
                List<Firetruck> fireturcksReturn = new List<Firetruck>();
                fireturcks = db.Firetruck.ToList();
                foreach (var i in fireturcks)
                {
                    if (Monday) { if (i.Monday == Monday) fireturcksReturn.Add(i); }
                    if (Tuesday) { if (i.Tuesday == Tuesday) fireturcksReturn.Add(i); }
                    if (Wednesday) { if (i.Wednesday == Wednesday) fireturcksReturn.Add(i); }
                    if (Thursday) { if (i.Thursday == Thursday) fireturcksReturn.Add(i); }
                    if (Firday) { if (i.Friday == Firday) fireturcksReturn.Add(i); }
                    if (Saturday) { if (i.Saturday == Saturday) fireturcksReturn.Add(i); }
                    if (Sunday) { if (i.Sunday == Sunday) fireturcksReturn.Add(i); }
                }
                return fireturcksReturn;
            }
        }

        public void UpdateFiretruck(int id, Firetruck firetruck)

        {

            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var firetruckToUpdate = db.Firetruck.Where(u => u.Id == id).FirstOrDefault();
                if (firetruckToUpdate != null)
                {
                    firetruckToUpdate.Id = id;
                    db.SaveChanges();
                }
            }
        }


        public void DeleteFiretruck(int id)
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var firetruckToDelete = db.Firetruck.Where(u => u.Id == id).FirstOrDefault();
                if (firetruckToDelete != null)
                {
                    db.Firetruck.Remove(firetruckToDelete);
                    db.SaveChanges();
                }
            }
        }

    }
}
