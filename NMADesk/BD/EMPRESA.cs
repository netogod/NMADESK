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
    
    public partial class EMPRESA
    {
        public EMPRESA()
        {
            this.CLIENTE = new HashSet<CLIENTE>();
            this.CONTRATO = new HashSet<CONTRATO>();
            this.PROFESIONAL = new HashSet<PROFESIONAL>();
        }
    
        public decimal RUT_EMP { get; set; }
        public string DV_EMP { get; set; }
        public string RAZ_SOC_EMP { get; set; }
        public string NOM_EMPRESA { get; set; }
    
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
        public virtual ICollection<PROFESIONAL> PROFESIONAL { get; set; }
    }
}
