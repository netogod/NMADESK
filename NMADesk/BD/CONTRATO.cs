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
    
    public partial class CONTRATO
    {
        public CONTRATO()
        {
            this.DETALLE_SERV = new HashSet<DETALLE_SERV>();
        }
    
        public decimal ID_CONTRATO { get; set; }
        public System.DateTime FECHA_EMIS { get; set; }
        public decimal PAGO_CONT { get; set; }
        public System.DateTime VALID { get; set; }
        public string STATUS_CONT { get; set; }
        public decimal EMPRESA_RUT_EMP { get; set; }
        public decimal CLIENTE_RUT_CLI { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual ICollection<DETALLE_SERV> DETALLE_SERV { get; set; }
    }
}
