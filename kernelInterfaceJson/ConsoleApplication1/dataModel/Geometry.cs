using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.dataModel
{
    /// <summary>
    /// The <c>Node</c> class.
    /// Defines a node, continaing three coordinates.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// X coordinate of the node
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Z coordinate of the node
        /// </summary>
        public double Z { get; set; }
    }

    public class Layer
    {
        /// <summary>
        /// List of nodes that enclose the area of the layer
        /// </summary>
        public IList<int> Area { get; set; }

        /// <summary>
        /// Name of the material assigned to this layer 
        /// </summary>
        public string Material { get; set; }

    }

    /// <summary>
    /// The <c>ModelGeometry</c> class.
    /// Defines all the geometry (points, curves, boundaries) used in the model.
    /// </summary>

    public class ModelGeometry
    {
        /// <summary>
        /// Colection of all points of the geometry
        /// </summary>
        public IList<Node> Nodes { get; set; }

        /// <summary>
        /// IList of all Curves of the geometry.
        /// Each curve is defined as an IList of the nodes that define it
        /// </summary>
        public IList<Layer> Layers { get; set; }

    }
}
