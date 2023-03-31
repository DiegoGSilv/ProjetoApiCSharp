using DesafioDev2.Models;
using DesafioDev2.Repositorios;
using DesafioDev2.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace DesafioDev2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoasRepositorio _pessoasRepositorio;
      public PessoasController(IPessoasRepositorio pessoasRepositorio)
        {

            _pessoasRepositorio = pessoasRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PessoasModel>>> BuscarTodasPessoas()
        {
           
           List<PessoasModel> pessoas = await _pessoasRepositorio.BuscarTodasPessoas();
            return Ok(pessoas);
        }

        [HttpGet("{codigo}")]
        public async Task<ActionResult<PessoasModel>> BuscarPorCodigo(int codigo)
        {

            PessoasModel pessoas = await _pessoasRepositorio.BuscarPorCodigo(codigo);
            return Ok(pessoas);

        }

        [HttpPost]
        public async Task<ActionResult<PessoasModel>> Cadastrar([FromBody] PessoasModel pessoasModel)
        {
            PessoasModel pessoas = await _pessoasRepositorio.Adicionar(pessoasModel);
            return Ok(pessoasModel);
        }
    }
}
