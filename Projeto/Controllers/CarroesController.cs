﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Projeto.DAL;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class CarroesController : ApiController
    {
        private AntigosContext db = new AntigosContext();

        // GET: api/Carroes
        public IQueryable<Carro> GetCarroes()
        {
            return db.Carroes;
        }

        // GET: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult GetCarro(int id)
        {
            Carro carro = db.Carroes.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            return Ok(carro);
        }

        // PUT: api/Carroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarro(int id, Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carro.ID_CARRO)
            {
                return BadRequest();
            }

            db.Entry(carro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(id))
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

        // POST: api/Carroes
        [ResponseType(typeof(Carro))]
        public IHttpActionResult PostCarro(Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carroes.Add(carro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carro.ID_CARRO }, carro);
        }

        // DELETE: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult DeleteCarro(int id)
        {
            Carro carro = db.Carroes.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            db.Carroes.Remove(carro);
            db.SaveChanges();

            return Ok(carro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarroExists(int id)
        {
            return db.Carroes.Count(e => e.ID_CARRO == id) > 0;
        }
    }
}