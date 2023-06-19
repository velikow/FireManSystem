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
            using(FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var lastFireman = db.Fireman.ToList().LastOrDefault();
                if (lastFireman == null)
                {
                    fireman.Id = 1;
                }
                else
                {
                    fireman.Id = lastFireman.Id + 1;
                }
                db.Fireman.Add(fireman);
                db.SaveChanges();
            }
        }
        internal List<Fireman> ReadAllFireman()
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                return db.Fireman.ToList();
            }
        }

        public void UpdateFireman(int id, Fireman fireman)
        {
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var firemanToUpdate = db.Fireman.Where(u => u.Id == id).FirstOrDefault();
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
            using (FiremanDBEntities2 db = new FiremanDBEntities2())
            {
                var firemanToDelete = db.Fireman.Where(u => u.Id == id).FirstOrDefault();
                if (firemanToDelete != null)
                {
                    db.Fireman.Remove(firemanToDelete);
                    db.SaveChanges();
                }
            }
        }

    }
}
