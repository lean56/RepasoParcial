using Microsoft.EntityFrameworkCore;
using Repso.Data;
using Repso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repso.Controllers
{
    public class ProductoController
    {
        public bool Guardar(Productos productos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (productos.ProductosId==0)
                {
                    paso = Insertar(productos);
                }
                else
                {
                    paso = Modificar(productos);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Productos productos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Productos.Add(productos);
            paso = db.SaveChanges() > 0;

            return paso;
        }

        private bool Modificar(Productos productos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Productos.Add(productos).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Productos Buscar(int id)
        {
            Contexto db = new Contexto();
            Productos productos = new Productos();

            try
            {
                productos = db.Productos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return productos;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Productos productos = new Productos();

            try
            {
                productos = db.Productos.Find(id);
                db.Entry(productos).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public List<Productos> GetProductos(Expression<Func<Productos, bool>> expression)
        {
            List<Productos> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.Productos.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    }
}
