using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.dataModel
{
    public class DataModel
    {
        /// <summary>
        /// Collection of Soils in the datamodel
        /// </summary>
        public IList<Soil> SoilCollection { get; set; }

        /// <summary>
        /// Geometry of the data model.
        /// </summary>
        public ModelGeometry Geometry { get; set; }


        /// <summary>
        /// Settings defining the specific calculation that needs to be carried out
        /// </summary>
        public IList<string> Lem { get; set; }

        /// <summary>
        /// Slip circles definition in X direction, Y Direction and Tangent lines
        /// </summary>
        public IList<Circle> Circles { get; set; }
    }
}
