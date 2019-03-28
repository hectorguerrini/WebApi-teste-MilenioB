using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
   
    public class ClientesController : ApiController
    {
        private milenioBusEntities2 db = new milenioBusEntities2();

        // GET: api/Clientes
        public IQueryable<MB_CLIENTE> GetMB_CLIENTE()
        {
            return db.MB_CLIENTE;
        }

        // GET: api/Clientes/5
        [ResponseType(typeof(MB_CLIENTE))]
        public IHttpActionResult GetMB_CLIENTE(int id)
        {
            MB_CLIENTE mB_CLIENTE = db.MB_CLIENTE.Find(id);
            if (mB_CLIENTE == null)
            {
                return NotFound();
            }

            return Ok(mB_CLIENTE);
        }

        // PUT: api/Clientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMB_CLIENTE(int id, MB_CLIENTE mB_CLIENTE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mB_CLIENTE.id_cliente)
            {
                return BadRequest();
            }

            db.Entry(mB_CLIENTE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MB_CLIENTEExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Clientes
        [ResponseType(typeof(MB_CLIENTE))]
        public IHttpActionResult PostMB_CLIENTE(MB_CLIENTE mB_CLIENTE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MB_CLIENTE.Add(mB_CLIENTE);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mB_CLIENTE.id_cliente }, mB_CLIENTE);
        }

        // DELETE: api/Clientes/5
        [ResponseType(typeof(MB_CLIENTE))]
        public IHttpActionResult DeleteMB_CLIENTE(int id)
        {
            MB_CLIENTE mB_CLIENTE = db.MB_CLIENTE.Find(id);
            if (mB_CLIENTE == null)
            {
                return NotFound();
            }

            db.MB_CLIENTE.Remove(mB_CLIENTE);
            db.SaveChanges();

            return Ok(mB_CLIENTE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MB_CLIENTEExists(int id)
        {
            return db.MB_CLIENTE.Count(e => e.id_cliente == id) > 0;
        }
    }
}