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
    
    public partial class CLIENTE
    {
        public CLIENTE()
        {
            this.CONTRATO = new HashSet<CONTRATO>();
            this.EMPLEADOS = new HashSet<EMPLEADOS>();
            this.SERVICIO = new HashSet<SERVICIO>();
            this.SUCURSAL = new HashSet<SUCURSAL>();
        }
    
        public decimal RUT_CLI { get; set; }
        public string DV_CLI { get; set; }
        public string RAZ_SOC_CLI { get; set; }
        public string MAIL_CLI { get; set; }
        public string STAT_CLI { get; set; }
        public decimal TEL_CLI { get; set; }
        public decimal EMPRESA_RUT_EMP { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
        public virtual ICollection<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual ICollection<SERVICIO> SERVICIO { get; set; }
        public virtual ICollection<SUCURSAL> SUCURSAL { get; set; }
    }
}
