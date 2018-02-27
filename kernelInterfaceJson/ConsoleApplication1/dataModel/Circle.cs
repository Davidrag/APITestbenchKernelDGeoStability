using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.dataModel
{
    /// <summary>
    /// Slip circle definition.
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// X-left or Y-bottom
        /// </summary>
        public double XValue { get; set; }

        /// <summary>
        /// X-right or Y-top
        /// </summary>
        public double YValue { get; set; }

        /// <summary>
        /// Number of slip circles in this direction
        /// </summary>
        public double TangentValue { get; set; }

    }
}
