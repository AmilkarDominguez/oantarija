//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oantarija.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_registro_meteo
    {
        public int id { get; set; }
        public int registro_meteo { get; set; }
        public bool estado { get; set; }
    
        public virtual registro_meteo registro_meteo1 { get; set; }
    }
}
