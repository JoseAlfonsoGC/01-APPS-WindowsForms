using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_WindowsForms_crud_basic_ADO_NET
{
    class CDatos
    {
        dbcrudbasicEntities db;

        public void Create(persona opPersona)
        {
            try
            {
                using(db= new dbcrudbasicEntities())
                {
                    db.persona.Add(opPersona);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<persona> Read()
        {
            try
            {
                using (db = new dbcrudbasicEntities())
                {
                    return db.persona.ToList();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void Update(persona opPersona)
        {
            try
            {
                using (db = new dbcrudbasicEntities())
                {
                    db.Entry(opPersona).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public void Delete(int opId)
        {
            try
            {
                using (db = new dbcrudbasicEntities())
                {
                    db.persona.Remove(db.persona.Single
                        (p => p.id == opId));
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public List<persona> buscarId(int opId)
        {
            try
            {
                using (db = new dbcrudbasicEntities())
                {
                    return db.persona.Where(p => p.id == opId).ToList();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public List<persona> buscarNombre(string opNombre)
        {
            try
            {
                using (db = new dbcrudbasicEntities())
                {
                    return db.persona.Where(p =>
                    p.nombre.Contains(opNombre)).ToList();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
