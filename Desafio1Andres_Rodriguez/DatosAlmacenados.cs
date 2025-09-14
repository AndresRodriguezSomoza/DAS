using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Andres_Rodriguez
{
    public static class DatosAlmacenados
    {
        public static List<Books> Libros { get; } = new List<Books>();
        public static List<Users> Usuarios { get; } = new List<Users>();

        public static List<Lending> Lending { get; } = new List<Lending>();
    }
}
