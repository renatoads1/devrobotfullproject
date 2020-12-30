using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using devrobot.Data;
using devrobot.Models;

namespace devrobot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaosController : ControllerBase
    {
        private readonly DevRobotContext _context;

        public AutenticacaosController(DevRobotContext context)
        {
            _context = context;
        }

        // GET: api/Autenticacaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autenticacao>>> GetAutenticacao(string user,string password)
        {
            return await _context.Autenticacao.Where(a => a.User == user && a.Senha == password).ToListAsync();
        }

        // GET: api/Autenticacaos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autenticacao>> GetAutenticacao(int id)
        {
            var autenticacao = await _context.Autenticacao.FindAsync(id);

            if (autenticacao == null)
            {
                return NotFound();
            }

            return autenticacao;
        }



        // PUT: api/Autenticacaos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutenticacao(int id, Autenticacao autenticacao)
        {
            if (id != autenticacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(autenticacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutenticacaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Autenticacaos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Autenticacao>> PostAutenticacao(Autenticacao autenticacao)
        {
            _context.Autenticacao.Add(autenticacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutenticacao", new { id = autenticacao.Id }, autenticacao);
        }

        // DELETE: api/Autenticacaos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Autenticacao>> DeleteAutenticacao(int id)
        {
            var autenticacao = await _context.Autenticacao.FindAsync(id);
            if (autenticacao == null)
            {
                return NotFound();
            }

            _context.Autenticacao.Remove(autenticacao);
            await _context.SaveChangesAsync();

            return autenticacao;
        }

        private bool AutenticacaoExists(int id)
        {
            return _context.Autenticacao.Any(e => e.Id == id);
        }
    }
}
