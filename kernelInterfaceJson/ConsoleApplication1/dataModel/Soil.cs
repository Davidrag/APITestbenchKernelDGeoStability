namespace ConsoleApplication1.dataModel
{
    /// <summary>
    /// The basic <c>Soil</c> class.
    /// This class contains the minimum soil attributes required for a sum to be run.
    /// </summary>
    public class Soil
    {
        /// <summary>
        /// Name of the soil [-]
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Unit weight above phreatic level [kN/m3]
        /// </summary>
        public double SoilGamDry { get; set; }
        /// <summary>
        /// Cohesion (c) [kN/m2]
        /// </summary>
        public double SoilCohesion { get; set; }
        /// <summary>
        /// friction angle (phi) [deg]
        /// </summary>
        public double SoilPhi { get; set; }
        /// <summary>
        /// Dilatancy (psi) [deg]
        /// </summary>
        public double SoilDilatancy { get; set; }

    }
}
