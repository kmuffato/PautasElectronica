using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PautasPublicidad.DTO
{
    [SortField(Property = "IdentifGrupo")]
    [Serializable]
    public class GrupoMediosPubDTO : TablaBase
    {
        //Properties...
        ////public int RecId { get; set; }
        ////public int DatareaId { get; set; }
        public string IdentifGrupo { get; set; }
        public string Name { get; set; }

    }
}
