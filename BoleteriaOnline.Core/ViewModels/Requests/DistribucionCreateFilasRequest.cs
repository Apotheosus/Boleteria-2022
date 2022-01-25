using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoleteriaOnline.Core.ViewModels.Requests
{
    public class DistribucionCreateFilasRequest
    {
        public int DistribucionId { get; set; }

        public int Filas { get; set; }

    }
}
