// -----------------------------------------------------------------------
// <copyright file="RBF.cs" company="BSUIR">
// Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab03_RBF
{
    /// <summary>
    /// Class for RBF network representation.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class RBF
    {
        #region Private Fields

        private double error; 

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the alpha.
        /// </summary>
        /// <value>
        /// The alpha.
        /// </value>
        public double Alpha { get; private set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public double Error {
            get { return error * 2.2; }
            private set { error = value; }
        }

        /// <summary>
        /// Gets the timeout.
        /// </summary>
        /// <value>
        /// The timeout.
        /// </value>
        public double Timeout { get; private set; }

        /// <summary>
        /// Gets the vectors.
        /// </summary>
        /// <value>
        /// The vectors.
        /// </value>
        public VectorsContainer Vectors { get; private set; } 

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RBF"/> class.
        /// </summary>
        /// <param name="alpha">The alpha.</param>
        /// <param name="error">The error.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="vectors">The vectors.</param>
        public RBF(double alpha, double error, double timeout, VectorsContainer vectors)
        {
            Alpha = alpha;
            Error = error;
            Timeout = timeout;
            Vectors = vectors;
        } 

        #endregion
    }
}
