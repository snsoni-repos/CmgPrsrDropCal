using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmgPrsrDropCal
{
    internal interface IData
    {
        double inletPrsr { get; set; }
        double inletOilRate { get; set; }
        double inletWaterRate { get; set; }
        double inletGasRate { get; set; }
        double pipeId { get; set; }
        double pipeLength { get; set; }
        double incliantion { get; set; }
        double oilVis { get; set; }
        double gasVis { get; set; }
        double waterVis { get; set; }
    }
}
