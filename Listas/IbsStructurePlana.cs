using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas
{
   public class IbsStructurePlana
    {
        #region  ATRIBUTOS
            public int codigo { get; set; }
            public string numID { get; set; }
            public string tipoID { get; set; }
            public string causal { get; set; }
            public string fuente { get; set; }
            public string Novedad { get; set; }
            public TipoPersona tipoPersona { get; set; }            
            public string nombreCompleto { get; set; }
            public string nombres { get; set; }
            public string apellidos { get; set; }            
            public string departamento { get; set; }
            public string pais { get; set; }
            public string direccion1 { get; set; }
            public string direccion2 { get; set; }
            public string direccion3 { get; set; }
            public DateTime? fechaNacimiento { get; set; }
            public DateTime? fechaInclusion { get; set; }
        #endregion
    }
}
