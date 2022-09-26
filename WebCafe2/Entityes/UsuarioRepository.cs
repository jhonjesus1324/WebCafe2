using System.Collections.Generic;
using System.Linq;

namespace WebCafe2.Entityes
{
    public class UsuarioRepository
    {
        public static List<Usuarios> Usuarios { get; set; }

        public static void Add(Usuarios usuarios)
        {
            if (Usuarios == null)
                Usuarios = new List<Usuarios>();

            Usuarios.Add(usuarios);
        }

        public static Usuarios GetBy(string code)
        {
            try
            {
                return Usuarios.FirstOrDefault(p => p.Code == code);
            }
            catch
            {
                return null;
            }
        }

        public static List<Usuarios> GetList()
        {
            return Usuarios;
        }

        public static void Remove(string code)
        {
            Usuarios.Remove(Usuarios.FirstOrDefault(p => p.Code == code));
        }

        public static string Modificar(string code, Usuarios usuario)
        {

            return "";
            //try
            //{
            //    Usuarios.FirstOrDefault(p => p.Code == code) = usuario;
            //    return "A alteração ocorreu bem!";
            //}
            //catch
            //{
            //    return "A alteração falhou!";
            //}
        }
    }
}