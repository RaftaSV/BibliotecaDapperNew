//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminLabrary.conexion
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administradores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Administradores()
        {
            this.Alquileres = new HashSet<Alquileres>();
            this.Alquileres1 = new HashSet<Alquileres>();
        }
    
        public int Id_Admin { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int Id_Lector { get; set; }
    
        public virtual Lectores Lectores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alquileres> Alquileres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alquileres> Alquileres1 { get; set; }
    }
}
