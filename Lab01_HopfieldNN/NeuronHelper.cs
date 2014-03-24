// -----------------------------------------------------------------------
// <copyright file="HeuronHelper.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_HopfieldNN
{
    using System.Drawing;

    /// <summary>
    /// Class of methors for mprk with neurons.
    /// </summary>
    public class NeuronHelper
    {
        private int vectorLength; 

        /// <summary>
        /// Convert picture to vector
        /// </summary>
        /// <param name="picture">The picture.</param>
        /// <returns></returns>
        public sbyte[] ConvertToVector(Bitmap picture)
        {
            vectorLength = PictureContainer.Size * PictureContainer.Size;

            var vector = new sbyte[vectorLength];

            for (var i = 0; i < PictureContainer.Size; i++)
            {
                for (var j = 0; j < PictureContainer.Size; j++)
                {
                    var pixel = picture.GetPixel(i, j);

                    if (pixel.R > 250)
                    {
                        vector[i * PictureContainer.Size + j] = 1;
                    }
                    else
                    {
                        vector[i * PictureContainer.Size + j] = -1;
                    }
                }
            }

            return vector;
        }

        /// <summary>
        /// Creates the coefficients matrix.
        /// </summary>
        /// <param name="matrixA">The matrix aggregate.</param>
        /// <param name="matrixB">The matrix attribute.</param>
        /// <param name="matrixC">The matrix asynchronous.</param>
        /// <returns></returns>
        public sbyte[,] CreateCoefficientsMatrix(sbyte[,] matrixA, sbyte[,] matrixB, sbyte[,] matrixC)
        {
            var resultMatrix = new sbyte[vectorLength, vectorLength];

            for (var i = 0; i < vectorLength; i++)
            {
                for (var j = 0; j < vectorLength; j++)
                {
                    if (i == j)
                    {
                        resultMatrix[i, j] = 0;
                    }
                    else
                    {
                        resultMatrix[i, j] = (sbyte)(matrixA[i, j] + matrixB[i, j] + matrixC[i, j]);    
                    }
                }
            }

            return resultMatrix;
        }

        /// <summary>
        /// Creates the matrix for pictures.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns></returns>
        public sbyte[,] CreateMatrix(sbyte[] vector)
        {
            var coefficientMatrix = new sbyte[vector.Length,vector.Length];

            for (var i = 0; i < vector.Length; i++)
            {
                for (var j = 0; j < vector.Length; j++)
                {
                    coefficientMatrix[i,j] = (sbyte) (vector[i] * vector[j]);
                }
            }

            return coefficientMatrix;
        }
    }
}
