using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicio_Insert.Models
{
    public class Alumno
    {
        [PrimaryKey, AutoIncrement]
        public int IdAlumno { get; set; }
        
        [MaxLength(50)]
        public string Nombre { get; set; }
        
        [MaxLength(50)]
        public string Apellido1 { get; set; }
        
        [MaxLength(50)]
        public string Apellido2 { get; set; }

        [MaxLength(10)]
        public int Edad { get; set; }

        [MaxLength(50)]
        public string Correo { get; set; }
    }
}
