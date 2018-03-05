using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKernelAPI.Solver
{
    interface ISlideSurface
    {
        /// <summary>
        /// List containing all points which define the first boundary of the search space.
        /// If only one case is evaluated, this boundary defines that case
        /// </summary>
        /// <returns>List of floats defining first boundary of case.</returns>
        IList<float> FirstBoundary();
        /// <summary>
        /// If the search space contains more than one case, this is the other boundary  delimiting the space
        /// </summary>
        /// <returns>List of floats defining the last boundary of the search space</returns>
        IList<float> LastBoundary();

    }
}
