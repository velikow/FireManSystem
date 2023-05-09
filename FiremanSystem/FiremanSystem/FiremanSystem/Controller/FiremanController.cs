using FiremanSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiremanSystem.Controller
{
    internal class FiremanController
    {
        internal void CreateFireman(Fireman fireman)
        {
            using(FiremanDBEntities db = new FiremanDBEntities())
            {
                var lastFireman = db.Firemen.ToList().LastOrDefault();
                if (lastFireman == null)
                {
                    fireman.Id = 1;
                }
                else
                {
                    fireman.Id = lastFireman.Id + 1;
                }
                db.Firemen.Add(fireman);
                db.SaveChanges();
            }
        }
        internal List<Fireman> ReadAllFireman()
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                return db.Firemen.ToList();
            }
        }

        public void UpdateFireman(int id, Fireman fireman)
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                var firemanToUpdate = db.Firemen.Where(u => u.Id == id).FirstOrDefault();
                if (firemanToUpdate != null)
                {
                    firemanToUpdate.Id = id;
                    firemanToUpdate.Username = fireman.Username;
                    firemanToUpdate.Password = fireman.Password;
                    db.SaveChanges();
                }
            }
        }

        
        public void DeleteFireman(int id)
        {
            using (FiremanDBEntities db = new FiremanDBEntities())
            {
                var firemanToDelete = db.Firemen.Where(u => u.Id == id).FirstOrDefault();
                if (firemanToDelete != null)
                {
                    db.Firemen.Remove(firemanToDelete);
                    db.SaveChanges();
                }
            }
        }

    }
}
