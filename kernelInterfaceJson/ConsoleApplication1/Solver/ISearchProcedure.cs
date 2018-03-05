using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKernelAPI.Solver
{
    public interface ISearchProcedure
    {
        /// <summary>
        /// Description of the search procedure
        /// </summary>
        /// <returns>String indicating the name: "One case", "Brute force", "Adaptive Particle Swarn Optimisation", "Genetic Algorithm", "Levenberg-Marquardt"</returns>
        string Description();
        /// <summary>
        /// Short name of the search procedure
        /// </summary>
        /// <returns>string indicating the Name (short name): "1", "BF", "APSO", "GA", "LM"</returns>
        string Name();
        /// <summary>
        /// Indicates if a search procedure will evaluate multiple cases
        /// </summary>
        /// <returns>true: if multiple cases will be evaluated; false: if only one case will be evaluated</returns>
        bool MultipleCases();
        /// <summary>
        /// List in steps in each direction of the search space
        /// These directions can be X, Z and R of first circle, X and Z of second circle, each vertex defining the vector of slide surface
        /// </summary>
        /// <returns>Vector with integers indicating number of steps in each direction of the search space</returns>
        IList<int> Steps();

        /// <summary>
        /// Any other arguments used by the search procedure
        /// </summary>
        /// <returns>String (for the time being) of any other orguments defining the search procedure</returns>
        string OtherArgs();

    }
}
