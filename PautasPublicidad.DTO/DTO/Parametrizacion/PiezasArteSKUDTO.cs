using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PautasPublicidad.DTO
{
   [Serializable]
    public class PiezasArteSKUDTO : TablaBase
    {
        //Properties...
        //public int RecId { get; set; }
        //public int DatareaId { get; set; }
        public string IdentifPieza { get; set; }
        public string IdentifSKU { get; set; }
        public string TipoProd { get; set; }
        public decimal? Coeficiente { get; set; }

    }
}
