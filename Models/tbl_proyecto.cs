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
    
    public partial class tbl_proyecto
    {
        public tbl_proyecto()
        {
            this.tbl_calificacion = new HashSet<tbl_calificacion>();
            this.tbl_comentario_proyecto = new HashSet<tbl_comentario_proyecto>();
        }
    
        public int tbl_proyecto_id { get; set; }
        public string tbl_proyecto_nombre { get; set; }
        public int tbl_equipo_id { get; set; }
        public int tbl_evento_id { get; set; }
        public string tbl_proyecto_url { get; set; }
        public string tbl_proyecto_git { get; set; }
        public bool tbl_proyecto_activo { get; set; }
        public int tbl_proyecto_estatus { get; set; }
    
        public virtual ICollection<tbl_calificacion> tbl_calificacion { get; set; }
        public virtual ICollection<tbl_comentario_proyecto> tbl_comentario_proyecto { get; set; }
        public virtual tbl_equipo tbl_equipo { get; set; }
        public virtual tbl_evento tbl_evento { get; set; }
    }
}
