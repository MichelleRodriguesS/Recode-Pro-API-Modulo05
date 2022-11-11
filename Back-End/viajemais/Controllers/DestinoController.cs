using Microsoft.AspNetCore.Mvc;
using viajemais.Model;
using viajemais.Repository;

namespace viajemais.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Destinos
    Controller : ControllerBase
    {
        //injetar dependencia do repositorio
        private readonly Id_Destinos
        Repository _repository;

        public UsuarioController(Id_Destinos
        Repository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Destino = await _repository.GetDestinos
            ();
            return Destino.Any() ? Ok(Destino) : NoContent();
        }

        [HttpPost]
        public IActionResult CriarDestinos
        (Destinos
         item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Destino.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }

        // GET: api/Destino - LISTA TODOS OS DESTINOS 
        [HttpGet]
        public IEnumerable<Destino> GetDestinos()
        {
            return _context.Destinos;
        }

        // GET: api/Destinos
        /id - LISTA Destino POR ID
        [HttpGet("{id}")]
        public IActionResult GetDestinos
        PorId(int idDestinos
        )
        {
            Destinos
             item = _context.Destino.SingleOrDefault(modelo => modelo.Destinos
            Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        
        [HttpPut("{idDestinos
        }")]
        public IActionResult AtualizaDestinos
        (int id, Destinos
         item)
        {
            if (idDestinos
             != item.Destinos
            Id)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }

        //DELETE: DELETAR UMA Destinos
         POR ID
        [HttpDelete("{idDestino
        }")]
        public IActionResult DeletaDestinos
        (int id)
        {
            var item = _context.Destino.SingleOrDefault(modelo => modelo.Destinos
            Id == idDestino
            );

            if (item == null)
            {
                return BadRequest();
            }

            _context.Destino.Remove(item);
            _context.SaveChanges();
            return Ok(item);
        }
    }
}