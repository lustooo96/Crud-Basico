using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CrudBascio.WebApi.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IValidator<Usuario> _usarioValidador;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio , IValidator<Usuario> usarioValidador)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _usarioValidador = usarioValidador;
        }

        [HttpGet]
        public IActionResult ObterTodosUsuarios()
        {
            try
            {
                List<Usuario>? usuarios = _usuarioRepositorio.Listar();
                if (usuarios == null) return NotFound();
                return Ok(usuarios);
            }
            catch (Exception error)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), this);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult ObterUmUsuario([FromRoute] int id)
        {
            try
            {
                var usuario = _usuarioRepositorio.BuscarUsuarioPorId(id);
                if (usuario == null) return NotFound();

                return Ok(usuario);
            }
            catch (Exception error)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), this);
            }
        }

        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var result = _usarioValidador.Validate(usuario);
                if (result.IsValid) {
                    _usuarioRepositorio.Salvar(usuario);
                    return NoContent();
                }   
                return BadRequest(new JsonResult(result.Errors));
            }
            catch (Exception error)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), new JsonResult(error.Message));
            }
        }

        [HttpPut]
        public IActionResult EditarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var result = _usarioValidador.Validate(usuario);
                if (result.IsValid)
                {
                    _usuarioRepositorio.Atualizar(usuario);
                    return NoContent();
                }
                return BadRequest(new JsonResult(result.Errors));
            }
            catch (Exception error)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), new JsonResult(error.Message));
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeletarUsuario([FromRoute] int id)
        {
            try
            {
                _usuarioRepositorio.Remover(id);
                return NoContent();
            }
            catch (Exception error)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), this) ;
            }

        }
    }
}