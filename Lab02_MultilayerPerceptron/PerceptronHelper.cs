// -----------------------------------------------------------------------
// <copyright file="PerceptronHelper.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab02_MultilayerPerceptron
{
    using System;

    /// <summary>
    /// Class represented methods for perceptron
    /// </summary>
    public class PerceptronHelper
    {
        /// <summary>
        /// The random
        /// </summary>
        private static readonly Random Random = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// The perceptron
        /// </summary>
        private Perceptron perceptron;

        /// <summary>
        /// The number on enter neurons
        /// </summary>
        private byte n;

        /// <summary>
        /// The number of neurons of hidden layer
        /// </summary>
        private byte h;

        /// <summary>
        /// The number of exit neurons
        /// </summary>
        private byte m;

        /// <summary>
        /// The hidden layer
        /// </summary>
        private double[,] V;

        /// <summary>
        /// The output layer
        /// </summary>
        private double[,] W;

        /// <summary>
        /// The threshold of the hidden layer
        /// </summary>
        private double[] Q;

        /// <summary>
        /// The threshold output layer
        /// </summary>
        private double[] T;

        /// <summary>
        /// The threshold of the hidden layer with sigma function
        /// </summary>
        private double[] G;

        /// <summary>
        /// The threshold output layer with sigma function
        /// </summary>
        private double[] Y;

        /// <summary>
        /// The error of output layer
        /// </summary>
        private double[] E;

        /// <summary>
        /// The error of hidden layer
        /// </summary>
        private double[] D;

        public int NumberOfIterations { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerceptronHelper" /> class.
        /// </summary>
        /// <param name="perceptron">The perceptron.</param>
        /// <param name="n">The asynchronous.</param>
        /// <param name="m">The command.</param>
        public PerceptronHelper(Perceptron perceptron, byte n, byte m)
        {
            this.perceptron = perceptron;
            this.n = n;
            this.h = (byte)(n / 2);
            this.m = m;

            V = this.GenerateMatrix(n, h);
            W = this.GenerateMatrix(h, m);

            Q = new double[h];
            T = new double[m];
            
            G = new double[h];
            Y = new double[m];
            
            E = new double[h];
            D = new double[m];
        }

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
        /// Initializes the randomly.
        /// </summary>
        /// <param name="layer">The layer.</param>
        private void InitializeRandomly(double[] layer)
        {
            for (var i = 0; i < layer.Length; i++)
            {
                layer[i] = this.GetRandomValue();
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
        /// Initializes the layers.
        /// </summary>
        private void InitializeLayers()
        {
            InitializeRandomly(V, n, h);
            InitializeRandomly(W, h, m);

            InitializeRandomly(Q);
            InitializeRandomly(T);
        }

        /// <summary>
        /// Teaches the vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        private double TeachVector(sbyte[] vector, int number)
        {
            var maxError = 0.0;

            // 2.1 
            for (var i = 0; i < h; i++)
            {
                var q = Q[i];

                for (var j = 0; j < n; j++)
                {
                    q += V[j, i] * vector[j];
                }

                G[i] = this.Sigma(q);
            }

            //2.2
            for (var i = 0; i < m; i++)
            {
                var t = T[i];

                for (var j = 0; j < h; j++)
                {
                    t += W[j, i] * G[j];
                }

                Y[i] = this.Sigma(t);
            }

            //2.6
            for (var i = 0; i < m; i++)
            {
                var value = 0.0;

                if (number == i)
                {
                    value = 1.0;

                }

                D[i] = value - Y[i];
               
                var abs = Math.Abs(D[i]);

                if (abs > maxError)
                {
                    maxError = abs;
                }
            }

            //2.11
            for (var i = 0; i < h; i++)
            {
                E[i] = 0.0;

                for (var j = 0; j < m; j++)
                {
                    E[i] += D[j] * (Y[j] * (1 - Y[j])) * W[i, j];
                }
            }

            //2.13
            for (var i = 0; i < h; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    W[i, j] += perceptron.Alpha * Y[j] * (1 - Y[j]) * D[j] * G[i];
                }
            }

            //2.14
            for (var i = 0; i < m; i++)
            {
                T[i] += perceptron.Alpha * Y[i] * (1 - Y[i]) * D[i];
            }      

            //2.15
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < h; j++)
                {
                    V[i, j] += perceptron.Beta * G[j] * (1 - G[j]) * E[j] * vector[i];
                }        
            }   

            //2.16
            for (var i = 0; i < h; i++)
            {
                Q[i] += perceptron.Beta * G[i] * (1 - G[i]) * E[i];
            }

            return maxError;
        }

        /// <summary>
        /// Sigmas the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private double Sigma(double value)
        {
            return 1.0 / (1.0 + Math.Exp(-value));
        }

        /// <summary>
        /// Determines whether the specified maximum error is teached.
        /// </summary>
        /// <param name="maxError">The maximum error.</param>
        /// <returns></returns>
        private bool IsTeached(double maxError)
        {
            return maxError < this.perceptron.Error || this.NumberOfIterations >= this.perceptron.Timeout;
        }

        /// <summary>
        /// Teaches this instance.
        /// </summary>
        public void Teach()
        {
            this.InitializeLayers();

            this.NumberOfIterations = 0;
            double maxError;
            var teached = false;

            while (!teached)
            {
                this.NumberOfIterations++;
                maxError = 0.0;

                var error = this.TeachVector(this.perceptron.Vectors.VectorA, 0);
                if (error > maxError)
                {
                    maxError = error;
                }

                error = this.TeachVector(perceptron.Vectors.VectorB, 1);
                if (error > maxError)
                {
                    maxError = error;
                }

                error = this.TeachVector(perceptron.Vectors.VectorC, 2);
                if (error > maxError)
                {
                    maxError = error;
                }

                teached = this.IsTeached(maxError);
            }
        }

        public double[] Recognize(sbyte[] vector)
        {
            //2.1
            for (var i = 0; i < h; i++)
            {
                var q = Q[i];

                for (var j = 0; j < n; j++)
                {
                    q += V[j, i] * vector[j];
                }

                G[i] = this.Sigma(q);
            }

            //2.2
            for (var i = 0; i < m; i++)
            {
                var t = T[i];

                for (var j = 0; j < h; j++)
                {
                    t += W[j, i] * G[j];
                }

                Y[i] = this.Sigma(t);
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
