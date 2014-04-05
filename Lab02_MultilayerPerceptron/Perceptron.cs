// -----------------------------------------------------------------------
// <copyright file="Perceptron.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab02_MultilayerPerceptron
{
    /// <summary>
    /// Class for perceptron
    /// </summary>
    public class Perceptron
    {
        /// <summary>
        /// Gets the alpha.
        /// </summary>
        /// <value>
        /// The alpha.
        /// </value>
        public double Alpha { get; private set; }

        /// <summary>
        /// Gets the beta.
        /// </summary>
        /// <value>
        /// The beta.
        /// </value>
        public double Beta { get; private set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public double Error { get; private set; }

        /// <summary>
        /// Gets the timeout.
        /// </summary>
        /// <value>
        /// The timeout.
        /// </value>
        public int Timeout { get; private set; }

        /// <summary>
        /// Gets the vectors.
        /// </summary>
        /// <value>
        /// The vectors.
        /// </value>
        public VectorsContainer Vectors { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Perceptron" /> class.
        /// </summary>
        /// <param name="alpha">The alpha.</param>
        /// <param name="beta">The beta.</param>
        /// <param name="error">The error.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="vectors">The vectors.</param>
        public Perceptron(double alpha, double beta, double error, int timeout, VectorsContainer vectors)
        {
            Alpha = alpha;
            Beta = beta;
            Error = error;
            Timeout = timeout;
            Vectors = vectors;
        }
    }
}
