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
    
    public partial class OSDDMW_DIAGRAMS
    {
        public decimal ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public string GLOBAL_ID { get; set; }
        public string DESIGN_ID { get; set; }
        public string DESIGN_NAME { get; set; }
        public string MODEL_ID { get; set; }
        public string MODEL_NAME { get; set; }
        public string SUBVIEW_ID { get; set; }
        public string SUBVIEW_NAME { get; set; }
        public string PARENT_ID { get; set; }
        public string DIAGRAM_TYPE { get; set; }
        public byte[] LAYOUT { get; set; }
    }
}
