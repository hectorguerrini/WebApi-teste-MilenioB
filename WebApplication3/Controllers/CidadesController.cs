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
    public class CidadesController : ApiController
    {
        private milenioBusEntities2 db = new milenioBusEntities2();

        // GET: api/Cidades
        public IQueryable<MB_COMBO_CIDADE> GetMB_COMBO_CIDADE()
        {
            return db.MB_COMBO_CIDADE;
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}