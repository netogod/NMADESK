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
    
    public partial class ASESORIA
    {
        public decimal ID_ASESORIA { get; set; }
        public string TIPO_ASESORIA { get; set; }
        public string DESC_ASESORIA { get; set; }
        public decimal SERV_DETALLE_ID_SERV_DETALLE { get; set; }
        public string STAT_ASESORIA { get; set; }
    
        public virtual SERV_DETALLE SERV_DETALLE { get; set; }
    }
}
