using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Andres_Rodriguez
{
    public class Books
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Año { get; set; }

        public Books() { }

        public Books(int id, string titulo, string autor, int año)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Año = año;
        }
    }
}
