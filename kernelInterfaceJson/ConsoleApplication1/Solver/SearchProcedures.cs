using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleKernelAPI.Solver;

namespace ConsoleApplication1.Solver
{

    public class OneCase : ISearchProcedure
    {
        public string Name()
        {
            return "OneCase";
        }

        public bool MultipleCases()
        {
            return false;
        }

        public string Description()
        {
            return "One case. No optimisation.";
        }

        public string OtherArgs()
        {
            return null;
        }

        public IList<int> Resolution()
        {
            return null;
        }
    }


    public class BruteForce : ISearchProcedure
    {
        public string Name()
        {
            return "BF";
        }

        public bool MultipleCases()
        {
            return true;
        }

        public string Description()
        {
            return "Brute force. Try all defined cases and select optimum one.";
        }

        public string OtherArgs()
        {
            // number of steps in each direction
            // extension of search space (move grid)?: boolean
            // Refinement of search resolution? : boolean
            throw new NotImplementedException();
        }

        public IList<int> Resolution()
        {
            throw new NotImplementedException();
        }
    }


    public class Apso : ISearchProcedure
    {
        public string Name()
        {
            return "Apso";
        }

        public bool MultipleCases()
        {
            return true;
        }

        public string Description()
        {
            return "Adaptive Particle Swarn Optimisation";
        }

        public string OtherArgs()
        {
            return "Still to be defined";
        }

        public IList<int> Resolution()
        {
            return null;
        }
    }


    public class Ga : ISearchProcedure
    {
        public int PopulationCount { get; set; }
        public int GenerationCount { get; set; }
        public int EliteCount { get; set; }
        public float Mutationrate { get; set; }
        public float ScatterFraction { get; set; } 
        public float SinglePointFraction { get; set; }
        public float DoublePointFraction { get; set; }
        public float JumpFraction { get; set; }
        public float CreepFraction { get; set; }
        public float InverseFraction { get; set; }
        public float CreepReduction { get; set; }


        public string Name()
        {
            return "GA";
        }

        public bool MultipleCases()
        {
            return true;
        }

        public string Description()
        {
            return "Genetic Algorithm";
        }

        public string OtherArgs()
        {
            var argsList = typeof(Ga).GetProperties().ToList();
            string argsString = "";
            foreach (var arg in argsList)
            {
                argsString = argsString + arg.Name + " = " + arg.GetValue(this, null).ToString() ?? "(null)";
            }
            return argsString;
        }

        public IList<int> Resolution()
        {
            throw new NotImplementedException();
        }
    }


    public class Lm : ISearchProcedure
    {
        public string Name()
        {
            return "LM";
        }

        public bool MultipleCases()
        {
            return true;
        }

        public string Description()
        {
            return "Levenberg - Marquardt";
        }

        public string OtherArgs()
        {
            throw new NotImplementedException();
        }

        public IList<int> Resolution()
        {
            return null;
        }
    }
    
}
