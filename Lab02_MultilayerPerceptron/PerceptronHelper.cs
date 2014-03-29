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
        private static Random random = new Random(DateTime.Now.Millisecond);

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

        private double[,] V;

        private double[,] W;

        private double[] Q;

        private double[] T;

        private double[] G;

        private double[] Y;

        private double[] E;

        private double[] D;
 
        /// <summary>
        /// Initializes a new instance of the <see cref="PerceptronHelper"/> class.
        /// </summary>
        /// <param name="perceptron">The perceptron.</param>
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

        private void InitializeRandomly(double[] layer)
        {
            for (var i = 0; i < layer.Length; i++)
            {
                layer[i] = this.GetRandomValue();
            }
        }

        private double GetRandomValue()
        {
            var rand = random.NextDouble();

            if (random.Next(0, 2) == 1)
            {
                rand = -rand;
            }

            return rand;
        }

        private void InitializeLayers()
        {
            InitializeRandomly(V, n, h);
            InitializeRandomly(W, h, m);

            InitializeRandomly(Q);
            InitializeRandomly(T);
        }

        public void Teach()
        {
            this.InitializeLayers();
        }
    }
}
