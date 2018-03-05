using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKernelAPI.Solver
{
    public interface ILem
    {
        /// <summary>
        /// Method that indicates the Limit Equilibrium Method used by a solver
        /// Current possibilities are: [Bishop, LiftVan, Spencer]
        /// </summary>
        /// <returns></returns>
        string Name();
    }
}
