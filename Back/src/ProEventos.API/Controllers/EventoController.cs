using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return  _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetByid(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.Eventoid == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post ";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
            // atualizar as informaçoes
        }

        [HttpDelete]
        public string HttpDelete(int id)
        {
            return $"Exemplo de HttpDelete com id = {id} ";
        }
    }
}
