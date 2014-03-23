// -----------------------------------------------------------------------
// <copyright file="HeuronHelper.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_HopfieldNN
{
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// Class of methors for mprk with neurons.
    /// </summary>
    public class HeuronHelper
    {
        /// <summary>
        /// Convert picture to vector
        /// </summary>
        /// <param name="picture">The picture.</param>
        /// <returns></returns>
        public IList<sbyte> ConvertToVector(Bitmap picture)
        {
            IList<sbyte> vector = new List<sbyte>(PictureContainer.Size * PictureContainer.Size);

            for (var i = 0; i < PictureContainer.Size; i++)
            {
                for (var j = 0; j < PictureContainer.Size; j++)
                {
                    var pixel = picture.GetPixel(i, j);

                    if (pixel.R > 255)
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
        public IList<IList<sbyte>> CreateCoefficientMatrix(IList<sbyte> vector)
        {
            IList<IList<sbyte>> coefficientMatrix = new List<IList<sbyte>>(vector.Count);

            for (var i = 0; i < vector.Count; i++)
            {
                for (var j = 0; j < vector.Count; j++)
                {
                    coefficientMatrix[i][j] = (sbyte) (vector[i] * vector[j]);
                }
            }

            return coefficientMatrix;
        }
    }
}
