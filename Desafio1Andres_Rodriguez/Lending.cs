using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Andres_Rodriguez
{
    public class Lending
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int LibroID { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public string UsuarioNombre => DatosAlmacenados.Usuarios.FirstOrDefault(u => u.ID == UserID)?.Nombre ?? "";

        public string LibroTitulo => DatosAlmacenados.Libros.FirstOrDefault(l => l.Id == LibroID)?.Titulo ?? "";
    }
}
