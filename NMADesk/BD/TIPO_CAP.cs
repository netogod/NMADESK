//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NMADesk.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_CAP
    {
        public TIPO_CAP()
        {
            this.CAPACITACION = new HashSet<CAPACITACION>();
        }
    
        public decimal ID_TIP_CAP { get; set; }
        public string TIPO_CAPAC { get; set; }
        public decimal CAPACITACION_ID_CAP { get; set; }
    
        public virtual ICollection<CAPACITACION> CAPACITACION { get; set; }
    }
}
