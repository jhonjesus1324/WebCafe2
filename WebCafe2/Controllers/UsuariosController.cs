using Microsoft.AspNetCore.Mvc;
using WebCafe2.Entityes;
namespace WebCafe.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UsuariosController
    {
        [HttpPost]
        public Usuarios SaveUsuarios(Usuarios usuario)
        {
            UsuarioRepository.Add(usuario);
            return usuario;
        }

        [HttpGet]
        public Usuarios ConsultarUsuario(string code)
        {
            var usuario = UsuarioRepository.GetBy(code);
            return usuario;
        }

        [HttpGet]
        public System.Collections.Generic.List<Usuarios> ConsultarListUsuarios()
        {
            var usuarios = UsuarioRepository.GetList();
            return usuarios;
        }

        //[HttpPut]
        //public Usuarios ModificarUsuarios(string Code)
        //{
        //    return;
        //}

        [HttpDelete]
        public string DeletarUsuarios(string code)
        {
            UsuarioRepository.Remove(code);
            return "Usuario removido";
        }
    }
}