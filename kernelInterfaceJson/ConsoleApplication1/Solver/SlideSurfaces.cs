using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKernelAPI.Solver
{
    public class Circle
    {
        public float XValue { get; set; }
        public float ZValue { get; set; }
        public float RadiusValue { get; set; }
    }

    public class StepsVector
    {
        public int XSteps { get; set; }
        public int ZSteps { get; set; }
        public int RadiusSteps { get; set; }
    }


    public class SlideOneCircle : ISlideSurface
    {
        public IList<Circle> Circles { get; set; }

        public StepsVector Resolution { get; set; }

        public IList<float> FirstBoundary()
        {
            return new List<float> { Circles[0].XValue, Circles[0].ZValue, Circles[0].RadiusValue };
        }

        public IList<float> LastBoundary()
        {
            if (Circles.Count>0)
            {
                return new List<float> { Circles[1].XValue, Circles[1].ZValue, Circles[1].RadiusValue };
            }
            throw new Exception("No second circle has been declared.");
            
        }

        public IList<int> Steps()
        {
            return new List<int> { Resolution.XSteps, Resolution.ZSteps, Resolution.RadiusSteps  };
        }
    }

    public class SlideTwoCircles : ISlideSurface
    {
        public IList<float> FirstBoundary()
        {
            throw new NotImplementedException();
        }

        public IList<float> LastBoundary()
        {
            throw new NotImplementedException();
        }

        public IList<int> Steps()
        {
            throw new NotImplementedException();
        }
    }

    public class SlideVector : ISlideSurface
    {
        public IList<float> FirstBoundary()
        {
            throw new NotImplementedException();
        }

        public IList<float> LastBoundary()
        {
            throw new NotImplementedException();
        }

        public IList<int> Steps()
        {
            throw new NotImplementedException();
        }
    }

}
