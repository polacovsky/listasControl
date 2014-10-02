using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas
{
    #region ENUMS    
    public enum TipoPersona { N,J};
    public  enum Genero  { M,H, I, S };

    #endregion
    public class IbsStructure
    {


        #region  ATRIBUTOS
        public int codigo { get; set; }
        public List<string> causales { get; set; }
        public string fuente { get; set; }
        public string Novedad { get; set; }
        public TipoPersona tipoPersona { get; set; }
        public String genero { get; set; }   
        public string nombreCompleto { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public List<Identificacion> identificaciones { get; set; }
        public string departamento { get; set; }
        public string pais { get; set; }
        public string direccion1 { get; set; }
        public string direccion2 { get; set; }
        public string direccion3 { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public DateTime? fechaInclusion { get; set; }
        #endregion

        public IbsStructure()
        {
            causales = new List<string>();
            identificaciones = new List<Identificacion>();
        }

        public class Identificacion
        {
            public string tipo { get; set; }
            public string numero { get; set; }

            public Identificacion(string tipo, string numero)
            {
                this.tipo = tipo;
                this.numero = numero;
            }

        }

    }
}
