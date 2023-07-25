using OtoServisSatis.DAL;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.BL
{
    public class MarkaManager
    {
        DatabaseContext contex = new DatabaseContext();
        public List<Marka> GetAll()
        {
            return contex.Markalar.ToList();
        }

        public int Add(Marka Marka)
        {
            contex.Markalar.Add(Marka);
            return contex.SaveChanges();
        }

        public int Update(Marka marka)
        {
            contex.Markalar.AddOrUpdate(marka);
            return contex.SaveChanges();
        }

        public int Delete(Marka marka)
        {
            contex.Markalar.Remove(marka);
            return contex.SaveChanges();
        }
        public Marka Get(int id)
        {
          return contex.Markalar.Find(id);
        }
    }
}
