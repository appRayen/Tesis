//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaCalculoweb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Perfil
    {
        public Perfil()
        {
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int IdPerfil { get; set; }
        public string Descripcion { get; set; }
        public short estado { get; set; }
        public string contraseña { get; set; }
    
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
