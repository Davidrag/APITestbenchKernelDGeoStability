using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleKernelAPI.Solver;

namespace ConsoleApplication1.Solver
{
    
    class Lem : ILem
    {
        public enum LimitEquilibriumMethod
        {
            Bishop,
            LiftVan,
            Spencer
        }

        private LimitEquilibriumMethod Selection;

        public string Name()
        {
            return Selection.ToString();
        }
    }
}


