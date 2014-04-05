// -----------------------------------------------------------------------
// <copyright file="RBFHepler.cs" company="BSUIR">
// Torchilov Pavel
// </copyright>
// -----------------------------------------------------------------------

namespace Lab03_RBF
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for BRF teaching and recognizing.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class RBFHepler
    {
        #region Private Fields

        /// <summary>
        /// The random
        /// </summary>
        private static readonly Random Random = new Random();

        /// <summary>
        /// The RBF
        /// </summary>
        private readonly RBF rbf;

        /// <summary>
        /// The number on neurons.
        /// </summary>
        private readonly byte n;

        /// <summary>
        /// The number of RBF neurons.
        /// </summary>
        private readonly byte h;

        /// <summary>
        /// The number of output neurons.
        /// </summary>
        private readonly byte m;

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

        /// <summary>
        /// The errors.
        /// </summary>
        private double[] D;

        /// <summary>
        /// The math wait
        /// </summary>
        private List<double[]> MathExpect;

        /// <summary>
        /// The standard deviation
        /// </summary>
        private double standardDeviation;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the number of iterations.
        /// </summary>
        /// <value>
        /// The number of iterations.
        /// </value>
        public int NumberOfIterations { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RBFHepler"/> class.
        /// </summary>
        /// <param name="rbf">The RBF.</param>
        /// <param name="n">The asynchronous.</param>
        /// <param name="m">The command.</param>
        public RBFHepler(RBF rbf, byte n, byte m)
        {
            this.rbf = rbf;
            this.n = n;
            this.h = m;
            this.m = m;

            this.G = new double[this.h];

            this.W = this.GenerateMatrix(h, m);
            this.Y = new double[this.m];

            this.D = new double[m];
            this.MathExpect = new List<double[]>(3);
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

        /// <summary>
        /// Initializes the randomly.
        /// </summary>
        /// <param name="layer">The layer.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        private void InitializeRandomly(double[,] layer, int width, int height)
        {
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    layer[i, j] = this.GetRandomValue();
                }
            }
        }

        /// <summary>
        /// Gets the random value.
        /// </summary>
        /// <returns></returns>
        private double GetRandomValue()
        {
            var rand = Random.NextDouble();

            if (Random.Next(0, 2) == 1)
            {
                rand = -rand;
            }

            return rand;
        }

        /// <summary>
        /// Gets the math wait.
        /// </summary>
        /// <param name="vector1">The vector1.</param>
        /// <param name="vector2">The vector2.</param>
        /// <param name="vector3">The vector3.</param>
        /// <returns></returns>
        private double[] GetMathWait(sbyte[] vector1, sbyte[] vector2, sbyte[] vector3)
        {
            var result = new double[n];

            for (var i = 0; i < n; i++)
            {
                result[i] = (vector1[i] + vector2[i] + vector3[i]) / 3.0;
            }

            return result;
        }

        /// <summary>
        /// Gets standard deviation.
        /// </summary>
        /// <param name="pictureA">The picture aggregate.</param>
        /// <param name="pictureB">The picture attribute.</param>
        /// <param name="pictureC">The picture asynchronous.</param>
        /// <returns></returns>
        private double GetStandardDeviation(double[] pictureA, double[] pictureB, double[] pictureC)
        {
            var standardDeviation1 = 0.0;
            var standardDeviation2 = 0.0;
            var standardDeviation3 = 0.0;

            for (var i = 0; i < n; i++)
            {
                standardDeviation1 += Math.Pow(pictureB[i] - pictureA[i], 2);
                standardDeviation2 += Math.Pow(pictureC[i] - pictureA[i], 2);
                standardDeviation3 += Math.Pow(pictureC[i] - pictureB[i], 2);
            }

            return Math.Min(Math.Min(standardDeviation1, standardDeviation2), standardDeviation3) / 2;
        }

        /// <summary>
        /// Teaches the vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="numberOfPicture">The number of picture.</param>
        /// <returns></returns>
        private double TeachVector(sbyte[] vector, byte numberOfPicture)
        {
            var maxError = 0.0;

            for (var i = 0; i < m; i++)
            {
                G[i] =
                    Math.Exp(
                        (-1) * (this.EuclideanDistance(vector, this.MathExpect[i]))
                        / Math.Pow(this.standardDeviation, 2));
            }

            for (var i = 0; i < m; i++)
            {
                var t = 0.0;

                for (var j = 0; j < h; j++)
                {
                    t += W[j, i] * G[j];
                }

                Y[i] = t;
            }

            for (var i = 0; i < m; i++)
            {
                if (i == numberOfPicture)
                {
                    D[i] = 1 - Y[i];
                }
                else
                {
                    D[i] = 0 - Y[i];
                }

                var abs = Math.Abs(D[i]);

                if (abs > maxError)
                {
                    maxError = abs;
                }
            }

            this.CorrectW();

            return maxError;
        }

        /// <summary>
        /// Euclidean distance the specified vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="mathWait">The math wait.</param>
        /// <returns></returns>
        private double EuclideanDistance(sbyte[] vector, double[] mathWait)
        {
            var result = 0.0;

            for (var i = 0; i < n; i++)
            {
                result += Math.Pow(vector[i] - mathWait[i], 2);
            }

            return result;
        }

        /// <summary>
        /// Corrects the forward.
        /// </summary>
        private void CorrectW()
        {
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < h; j++)
                {
                    W[i, j] += rbf.Alpha * D[j] * G[i];
                }
            }
        }

        /// <summary>
        /// Gets all vectors.
        /// </summary>
        /// <returns></returns>
        private List<sbyte[]> GetAllVectors()
        {
            var result = new List<sbyte[]>(m * h)
                             {
                                 this.rbf.Vectors.VectorA1,
                                 this.rbf.Vectors.VectorA2,
                                 this.rbf.Vectors.VectorA3,
                                 this.rbf.Vectors.VectorB1,
                                 this.rbf.Vectors.VectorB2,
                                 this.rbf.Vectors.VectorB3,
                                 this.rbf.Vectors.VectorC1,
                                 this.rbf.Vectors.VectorC2,
                                 this.rbf.Vectors.VectorC3
                             };

            return result;
        }

        private bool IsTeached(double maxError)
        {
            return maxError < rbf.Error || NumberOfIterations >= rbf.Timeout;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Teaches this instance.
        /// </summary>
        public void Teach()
        {
            this.InitializeRandomly(W, h, m);

            this.NumberOfIterations = 0;
            var teached = false;

            this.MathExpect.Add(this.GetMathWait(rbf.Vectors.VectorA1, rbf.Vectors.VectorA2, rbf.Vectors.VectorA3));
            this.MathExpect.Add(this.GetMathWait(rbf.Vectors.VectorB1, rbf.Vectors.VectorB2, rbf.Vectors.VectorB3));
            this.MathExpect.Add(this.GetMathWait(rbf.Vectors.VectorC1, rbf.Vectors.VectorC2, rbf.Vectors.VectorC3));

            this.standardDeviation = this.GetStandardDeviation(
                this.MathExpect[0],
                this.MathExpect[1],
                this.MathExpect[2]);

            var vectors = this.GetAllVectors();

            while (!teached)
            {
                this.NumberOfIterations++;
                var maxError = 0.0;

                for (var i = 0; i < m * h; i++)
                {
                    var error = this.TeachVector(vectors[i], (byte)(i / 3));

                    if (error > maxError)
                    {
                        maxError = error;
                    }
                }

                teached = IsTeached(maxError);
            }
        }

        /// <summary>
        /// Recognizes the specified noise vector.
        /// </summary>
        /// <param name="noiseVector">The noise vector.</param>
        /// <returns></returns>
        public double[] Recognize(sbyte[] noiseVector)
        {
            for (var i = 0; i < m; i++)
            {
                G[i] =
                    Math.Exp(
                        (-1) * (this.EuclideanDistance(noiseVector, this.MathExpect[i]))
                        / Math.Pow(this.standardDeviation, 2));
            }

            for (int i = 0; i < m; i++)
            {
                var t = 0.0;

                for (int j = 0; j < m; j++)
                {
                    t += W[j, i] * G[j];
                }

                Y[i] = t;
            }

            var result = new double[m];

            for (var i = 0; i < m; i++)
            {
                result[i] = Y[i] * 100;
            }

            return result;
        }

        #endregion
    }
}