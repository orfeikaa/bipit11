using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using bip11.Models;
using Nest;
using DocumentFormat.OpenXml.Wordprocessing;

namespace bip11.Controllers
{
    [Route("api/[ValuesController]")]
    public class ValuesController : ApiController
    {

        BIPITEntities context = new BIPITEntities();


        ValuesController()
        {
            context.Configuration.ProxyCreationEnabled = false;
        }

        [Route("~/api/GetArenda")]
        [HttpGet]
        public IEnumerable<Arenda> GetArenda()
        {
            return context.Arenda;
        }

        [Route("~/api/GetAvto")]
        [HttpGet]
        public IEnumerable<Avto> GetAvto()
        {
            return context.Avto;
        }

        [Route("~/api/GetFIO")]
        [HttpGet]
        public IEnumerable<FIO> GetFIO()
        {
            return context.FIO;
        }

        [Route("~/api/Avto/{id?}")]
        [HttpGet]
        public string Avto(int id)
        {
            Avto h = context.Avto.Find(id);
            return h.Model;
        }

        [Route("~/api/FIO/{id?}")]
        [HttpGet]
        public string FIO(int id)
        {
            FIO e = context.FIO.Find(id);
            return e.FIO1;
        }

        [Route("~/api/AddFIO")]
        [HttpPost]
        public void AddFIO([FromBody] FIO e)
        {
            context.FIO.Add(e);
            context.SaveChanges();
        }

        [Route("~/api/AddAvto")]
        [HttpPost]
        public void AddAvto([FromBody] Avto h)
        {
            context.Avto.Add(h);
            context.SaveChanges();
        }

        [Route("~/api/AddArenda")]
        [HttpPost]
        public void AddArenda([FromBody] Arenda t)
        {
            context.Arenda.Add(t);
            context.SaveChanges();
        }


        [Route("~/api/DeleteAvto/{id?}")]
        [HttpDelete]
        public void DeleteAvto(int id)
        {
            Avto Avto = context.Avto.Find(id);
            context.Avto.Remove(Avto);
            context.SaveChanges();
        }

        [Route("~/api/DeleteFIO/{id?}")]
        [HttpDelete]
        public void DeleteFIO(int id)
        {
            FIO e = context.FIO.Find(id);
            context.FIO.Remove(e);
            context.SaveChanges();
        }

        [Route("~/api/DeleteArenda/{id?}")]
        [HttpDelete]
        public void DeleteArenda(int id)
        {
            Arenda Arenda = context.Arenda.Find(id);
            context.Arenda.Remove(Arenda);
            context.SaveChanges();
        }
    }
}
