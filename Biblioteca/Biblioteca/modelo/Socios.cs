//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Socios
    {
        public Socios()
        {
            this.Alquiler = new HashSet<Alquiler>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> dni { get; set; }
    
        public virtual ICollection<Alquiler> Alquiler { get; set; }
    }
}
