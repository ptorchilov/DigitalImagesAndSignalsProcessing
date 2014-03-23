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
        /// <summary>
        /// Convert picture to vector
        /// </summary>
        /// <param name="picture">The picture.</param>
        /// <returns></returns>
        public sbyte[] ConvertToVector(Bitmap picture)
        {
            var vector = new sbyte[PictureContainer.Size * PictureContainer.Size];

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
        /// Creates the coefficient matrix W.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns></returns>
        public sbyte[,] CreateCoefficientMatrix(sbyte[] vector)
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
