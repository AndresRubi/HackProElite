//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HackProElite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_equipo_usuario
    {
        public int tbl_equipo_id { get; set; }
        public int tbl_usaurio_id { get; set; }
        public bool tbl_equipo_usuario_activo { get; set; }
    
        public virtual tbl_equipo tbl_equipo { get; set; }
        public virtual tbl_usuario tbl_usuario { get; set; }
    }
}
