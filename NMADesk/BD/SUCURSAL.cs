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
    
    public partial class SUCURSAL
    {
        public decimal ID_SUC { get; set; }
        public string NOMB_SUC { get; set; }
        public string DIRECCION_SUC { get; set; }
        public decimal CLIENTE_RUT_CLI { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
    }
}
