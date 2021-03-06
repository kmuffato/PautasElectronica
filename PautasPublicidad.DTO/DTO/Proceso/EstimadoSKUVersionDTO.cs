using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PautasPublicidad.DTO
{
    [Serializable]
    public class EstimadoSKUVersionDTO : TablaBase
    {
        //Properties...
        //public int RecId { get; set; }
        //public int DatareaId { get; set; }
        public string PautaId { get; set; }
        public string IdentifAviso { get; set; }
        public string IdentifSKU { get; set; }
        public decimal Duracion { get; set; }
        public decimal Costo { get; set; }
        public decimal CostoOp { get; set; }
        public decimal CostoUni { get; set; }
        public decimal CostoOpUni { get; set; }
        public decimal CantSalidas { get; set; }
        public decimal Version { get; set; }

        public EstimadoSKUVersionDTO()
        {
        }

        public EstimadoSKUVersionDTO(EstimadoSKUDTO estSKU)
        {
            DTOHelper.FillObjectByObject(estSKU, this);
        }
    }
}
