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
    
    public partial class tbl_comentario_proyecto
    {
        public int tbl_comentario_proyecto_id { get; set; }
        public int tbl_usuario_id { get; set; }
        public int tbl_proyecto_id { get; set; }
        public System.DateTime tbl_comentario_proyecto_fecha { get; set; }
        public string tbl_comentario_proyecto_comentario { get; set; }
        public Nullable<bool> tbl_comentario_proyecto_like { get; set; }
    
        public virtual tbl_proyecto tbl_proyecto { get; set; }
        public virtual tbl_usuario tbl_usuario { get; set; }
    }
}
