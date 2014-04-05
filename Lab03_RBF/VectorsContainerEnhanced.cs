// -----------------------------------------------------------------------
// <copyright file="VectorsContainerEnhanced.cs" company="BSUIR">
// Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab03_RBF
{
    /// <summary>
    /// Class for store vectors of pictures.
    /// </summary>
    public class VectorsContainer
    {
        #region Public Properties

        /// <summary>
        /// Gets the vector a1.
        /// </summary>
        /// <value>
        /// The vector a1.
        /// </value>
        public sbyte[] VectorA1 { get; private set; }

        /// <summary>
        /// Gets the vector a2.
        /// </summary>
        /// <value>
        /// The vector a2.
        /// </value>
        public sbyte[] VectorA2 { get; private set; }

        /// <summary>
        /// Gets the vector a3.
        /// </summary>
        /// <value>
        /// The vector a3.
        /// </value>
        public sbyte[] VectorA3 { get; private set; }

        /// <summary>
        /// Gets the vector b1.
        /// </summary>
        /// <value>
        /// The vector b1.
        /// </value>
        public sbyte[] VectorB1 { get; private set; }

        /// <summary>
        /// Gets the vector b2.
        /// </summary>
        /// <value>
        /// The vector b2.
        /// </value>
        public sbyte[] VectorB2 { get; private set; }

        /// <summary>
        /// Gets the vector b3.
        /// </summary>
        /// <value>
        /// The vector b3.
        /// </value>
        public sbyte[] VectorB3 { get; private set; }

        /// <summary>
        /// Gets the vector c1.
        /// </summary>
        /// <value>
        /// The vector c1.
        /// </value>
        public sbyte[] VectorC1 { get; private set; }

        /// <summary>
        /// Gets the vector c2.
        /// </summary>
        /// <value>
        /// The vector c2.
        /// </value>
        public sbyte[] VectorC2 { get; private set; }

        /// <summary>
        /// Gets the vector c3.
        /// </summary>
        /// <value>
        /// The vector c3.
        /// </value>
        public sbyte[] VectorC3 { get; private set; }

        #endregion

        #region Constructors

        public VectorsContainer(
            sbyte[] vectorA1,
            sbyte[] vectorA2,
            sbyte[] vectorA3,
            sbyte[] vectorB1,
            sbyte[] vectorB2,
            sbyte[] vectorB3,
            sbyte[] vectorC1,
            sbyte[] vectorC2,
            sbyte[] vectorC3)
        {
            VectorA1 = vectorA1;
            VectorA2 = vectorA2;
            VectorA3 = vectorA3;
            VectorB1 = vectorB1;
            VectorB2 = vectorB2;
            VectorB3 = vectorB3;
            VectorC1 = vectorC1;
            VectorC2 = vectorC2;
            VectorC3 = vectorC3;
        }

        #endregion
    }
}