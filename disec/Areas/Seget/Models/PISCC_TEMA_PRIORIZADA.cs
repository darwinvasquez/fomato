//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace disec.Areas.Seget.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PISCC_TEMA_PRIORIZADA
    {
        public decimal TEMATICA_ID { get; set; }
        public Nullable<decimal> OFPLA_PISCC_ID { get; set; }
        public Nullable<decimal> ID_TEMA_PRIORIZADO { get; set; }
        public Nullable<decimal> VIGENTE { get; set; }
        public string OTRO { get; set; }
        public Nullable<long> IDENTIFICACION_CREA { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public string MAQUINA_CREACION { get; set; }
    
        public virtual OFPLA_PISCC OFPLA_PISCC { get; set; }
    }
}
