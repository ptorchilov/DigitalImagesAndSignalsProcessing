// -----------------------------------------------------------------------
// <copyright file="RBFHepler.cs" company="BSUIR">
// Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab03_RBF
{
    /// <summary>
    /// Class for BRF teaching and recognizing.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class RBFHepler
    {
        #region Private Fields

        /// <summary>
        /// The RBF
        /// </summary>
        private RBF rbf;

        /// <summary>
        /// The number on neurons.
        /// </summary>
        private byte n;

        /// <summary>
        /// The number of RBF neurons.
        /// </summary>
        private byte h;

        /// <summary>
        /// The number of output neurons.
        /// </summary>
        private byte m;

        /// <summary>
        /// The output layer.
        /// </summary>
        private double[,] W;

        /// <summary>
        /// The threshold of the hidden layer.
        /// </summary>
        private double[] Y;

        /// <summary>
        /// The threshold of RBF.
        /// </summary>
        private double[] G; 

        #endregion

        #region Constructors

        public RBFHepler(RBF rbf, byte n, byte m)
        {
            this.rbf = rbf;
            this.n = n;
            this.h = m;
            this.m = m;

            this.W = this.GenerateMatrix(h, m);

        } 

        #endregion

        #region Private Methods

        /// <summary>
        /// Generates the matrix.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        private double[,] GenerateMatrix(byte width, byte height)
        {
            return new double[width, height];
        } 

        #endregion
    }
}
