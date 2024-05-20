using AlunosAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlunosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private IAlunosService _alunoService;

        public AlunosController(IAlunosService alunoService)
        {
            _alunoService = alunoService;
        }


    }
}
