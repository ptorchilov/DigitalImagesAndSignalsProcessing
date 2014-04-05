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

        /// <summary>
        /// The errors.
        /// </summary>
        private double[] D;

        private List<double[]> MathWait;

        private double sko;

        #endregion

        #region Public Properties

        public int NumberOfIterations { get; private set; }

        #endregion

        #region Constructors

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
            MathWait = new List<double[]>(3);
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

        private double[] GetMathWait(sbyte[] vector1, sbyte[] vector2, sbyte[] vector3)
        {
            var result = new double[n];

            for (var i = 0; i < n; i++)
            {
                result[i] = (vector1[i] + vector2[i] + vector3[i]) / 3.0;
            }

            return result;
        }

        private double GetSKO(double[] pictureA, double[] pictureB, double[] pictureC)
        {
            var sko1 = 0.0;
            var sko2 = 0.0;
            var sko3 = 0.0;
            
            for (var i = 0; i < n; i++)
            {
                sko1 += Math.Pow(pictureB[i] - pictureA[i], 2);
                sko2 += Math.Pow(pictureC[i] - pictureA[i], 2);
                sko3 += Math.Pow(pictureC[i] - pictureB[i], 2);
            }

            var sko = Math.Min(Math.Min(sko1, sko2), sko3);
            
            return sko / 2;
        }

        private double TeachVector(sbyte[] vector, double sko, byte numberOfPicture)
        {
            var maxError = 0.0;

            for (var i = 0; i < m; i++)
            {
                G[i] = Math.Exp((-1) * (Evklid_number(vector, MathWait[i])) / Math.Pow(sko, 2));
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

        private double Evklid_number(sbyte[] vector, double[] mathWait)
        {
            var result = 0.0;

            for (var i = 0; i < n; i++)
            {
                result += Math.Pow(vector[i] - mathWait[i], 2);
            }

            return result;
        }

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

        private List<sbyte[]> GetAllVectors()
        {
            var result = new List<sbyte[]>(m * h);
            
            result.Add(rbf.Vectors.VectorA1);
            result.Add(rbf.Vectors.VectorA2);
            result.Add(rbf.Vectors.VectorA3);
            result.Add(rbf.Vectors.VectorB1);
            result.Add(rbf.Vectors.VectorB2);
            result.Add(rbf.Vectors.VectorB3);
            result.Add(rbf.Vectors.VectorC1);
            result.Add(rbf.Vectors.VectorC2);
            result.Add(rbf.Vectors.VectorC3);

            return result;
        }

        private bool IsTeached(double maxError)
        {
            return maxError < rbf.Error || NumberOfIterations >= rbf.Timeout;
        }

        #endregion

        public void Teach()
        {
            this.InitializeRandomly(W, h, m);

            this.NumberOfIterations = 0;
            double maxError;
            var teached = false;

            MathWait.Add(this.GetMathWait(rbf.Vectors.VectorA1, rbf.Vectors.VectorA2, rbf.Vectors.VectorA3));
            MathWait.Add(this.GetMathWait(rbf.Vectors.VectorB1, rbf.Vectors.VectorB2, rbf.Vectors.VectorB3));
            MathWait.Add(this.GetMathWait(rbf.Vectors.VectorC1, rbf.Vectors.VectorC2, rbf.Vectors.VectorC3));

            sko = this.GetSKO(MathWait[0], MathWait[1], MathWait[2]);

            var vectors = new List<sbyte[]>(m * h);

            vectors = this.GetAllVectors();


            while (!teached)
            {
                this.NumberOfIterations++;
                maxError = 0.0;

                var error = 0.0;

                for (var i = 0; i < m * h; i++)
                {
                    error = this.TeachVector(vectors[i], sko, (byte) (i / 3));

                    if (error > maxError)
                    {
                        maxError = error;
                    }
                }

                teached = IsTeached(maxError);
            }
        }

        public double[] Recognize(sbyte[] noiseVector) 
        {
            for (var i = 0; i < m; i++)
            {
                G[i] = Math.Exp((-1) * (Evklid_number(noiseVector, MathWait[i])) / Math.Pow(sko, 2));
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
    }
}