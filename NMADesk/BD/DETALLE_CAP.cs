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
    
    public partial class DETALLE_CAP
    {
        public decimal ID_D_CAPA { get; set; }
        public decimal ID_PERSONAL { get; set; }
        public decimal ID_PROF_CAP { get; set; }
        public string ASISTE_PERS { get; set; }
        public decimal NOTA_PERS { get; set; }
        public decimal CAPACITACION_ID_CAP { get; set; }
    
        public virtual CAPACITACION CAPACITACION { get; set; }
    }
}