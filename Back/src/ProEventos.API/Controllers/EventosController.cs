using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
          return  _context.Eventos.FirstOrDefault(evento => evento.EventoId == id );
        }

         [HttpPost]
        public String Post()
        {
           return "POST";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
           return $"PUT ID: {id}";
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {
           return $"Delete ID: {id}";
        }
    }
}
