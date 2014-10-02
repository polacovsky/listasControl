using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas
{
    class NovedadCompilado
    {

        public string novedad { get; set; }
        public int cantidad { get; set; }
        public string descripcion
        {
            get
            {
                switch (novedad)
                {
                    case "A":
                        return "ACTUALIZADOS";
                    case "I":
                        return "NUEVOS INSERTADOS";
                    case "E":
                        return "ELIMINADOS";
                    case "N":
                        return "INTACTOS";
                    default:
                        return null;                        
                }
                
            }
            
        }

    }
}
