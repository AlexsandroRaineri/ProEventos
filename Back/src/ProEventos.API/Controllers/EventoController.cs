using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {

               new Evento(){
                  Eventoid = 1,
                  Tema = "Amgular 11 e .Net 5",
                  Local = "Sao Paulo",
                  Lote = "1 Lote",
                  QtdPesssoas = "300",
                  DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                  ImagemURL =  "Foto.png"
               },
               new Evento(){
                  Eventoid = 2,
                  Tema = "Amgular 11 e Suas novidades",
                  Local = "Sao Paulo",
                  Lote = "2 Lote",
                  QtdPesssoas = "350",
                  DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
                  ImagemURL =  "Foto1.png"
               }

        };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByid(int id)
        {
            return _evento.Where(evento => evento.Eventoid == id);
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
