using AlunosAPI.Models;
using AlunosAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AlunosController : ControllerBase
    {
        private IAlunosService _alunoService;

        public AlunosController(IAlunosService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Aluno>>> GetAlunos()
        {
                var alunos = await _alunoService.GetAlunos();

                if (alunos is not null)
                    return Ok(alunos);

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter alunos");
        }

        [HttpGet("get-by-name")]
        public async Task<ActionResult<IAsyncEnumerable<Aluno>>> GetAlunosByName([FromQuery] string name)
        {
            var alunos = await _alunoService.GetAlunosByNome(name);

            if (alunos is not null)
                return Ok(alunos);
            else if (alunos.Count() == 0)
                return NotFound("Nenhum aluno encontrado");

            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter alunos");
        }

        [HttpGet("{id:int}", Name ="get-by-id")]
        public async Task<ActionResult<IAsyncEnumerable<Aluno>>> GetAluno(int id)
        {
            var aluno = await _alunoService.GetAluno(id);

            if (aluno is not null)
                return Ok(aluno);

            return StatusCode(StatusCodes.Status500InternalServerError, "Aluno não encontrado");
        }

        [HttpPost]
        public async Task<ActionResult> CreateAluno(Aluno aluno)
        {
            try
            {
                await _alunoService.CreateAluno(aluno);
                return CreatedAtRoute("get-by-id", new { id = aluno.Id }, aluno);
            }
            catch
            {
                return BadRequest("Requisição inválida");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Edit(int id, [FromBody] Aluno aluno)
        {
            try
            {
                if (aluno.Id == id)
                {
                    await _alunoService.UpdateAluno(aluno);
                    return Ok("Aluno atualizado");
                }
                else
                {
                    return BadRequest("Dados inconsistentes");
                }
            }
            catch
            {
                return BadRequest("Requisição inválida");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var aluno = await _alunoService.GetAluno(id);
                if (aluno is not null)
                { 
                    await _alunoService.DeleteAluno(aluno);
                    return Ok("Aluno excluído");
                }
                else
                {
                    return NotFound("Aluno não encontrado");
                }
            }
            catch 
            {
                return BadRequest("Requisição inválida");
            }
        }
    }
}
