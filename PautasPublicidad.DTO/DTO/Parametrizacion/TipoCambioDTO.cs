using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PautasPublicidad.DTO
{
   [Serializable]
    public class TipoCambioDTO : TablaBase
    {
        //Properties...
        //public int RecId { get; set; }
        //public int DatareaId { get; set; }
        public string IdentifMon { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal Valor { get; set; }

    }
}
