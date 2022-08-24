using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CrudBascio.WebApi.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public IActionResult ObterTodosUsuarios()
        {
            try
            {
                var usuarios = _usuarioRepositorio.Listar();
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
                _usuarioRepositorio.Salvar(usuario);
                return NoContent();
            }
            catch (Exception error)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), this);
            }
        }

        [HttpPut]
        public IActionResult EditarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioRepositorio.Atualizar(usuario);
                return NoContent();
            }
            catch (Exception error)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), this);
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