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
    
    public partial class envio
    {
        public int id { get; set; }
        public int boletin { get; set; }
        public int suscripcion { get; set; }
        public bool estado { get; set; }
    
        public virtual boletin boletin1 { get; set; }
        public virtual suscripcion suscripcion1 { get; set; }
    }
}
