// -----------------------------------------------------------------------
// <copyright file="VectorsContainer.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab02_MultilayerPerceptron
{
    /// <summary>
    /// Class for store vectors of picture
    /// </summary>
    public class VectorsContainer
    {
        /// <summary>
        /// Gets the vector A.
        /// </summary>
        /// <value>
        /// The vector A.
        /// </value>
        public sbyte[] VectorA { get; private set; }

        /// <summary>
        /// Gets the vector B.
        /// </summary>
        /// <value>
        /// The vector B.
        /// </value>
        public sbyte[] VectorB { get; private set; }

        /// <summary>
        /// Gets the vector C.
        /// </summary>
        /// <value>
        /// The vector C.
        /// </value>
        public sbyte[] VectorC { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorsContainer" /> class.
        /// </summary>
        /// <param name="vectorA">The vector A.</param>
        /// <param name="vectorB">The vector B.</param>
        /// <param name="vectorC">The vector C.</param>
        public VectorsContainer(sbyte[] vectorA, sbyte[] vectorB, sbyte[] vectorC)
        {
            VectorA = vectorA;
            VectorB = vectorB;
            VectorC = vectorC;
        }
    }
}
