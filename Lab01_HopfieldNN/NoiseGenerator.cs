// -----------------------------------------------------------------------
// <copyright file="NoiseGenerator.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_HopfieldNN
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Class for generate noise on picture.
    /// </summary>
    public static class NoiseGenerator
    {
        /// <summary>
        /// The random
        /// </summary>
        private static readonly Random Random = new Random();

        /// <summary>
        /// The max value of RGB.
        /// </summary>
        private static readonly int RGBMAX = 255;

        /// <summary>
        /// Generates the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="noiseLevel">The noise level.</param>
        /// <returns></returns>
        public static Bitmap Generate(String path, int noiseLevel)
        {
            var picture = new Bitmap(path);

            return Generate(picture, noiseLevel);
        }

        /// <summary>
        /// Generates the specified picture.
        /// </summary>
        /// <param name="picture">The picture.</param>
        /// <param name="noiseLevel">The noise level.</param>
        /// <returns></returns>
        public static Bitmap Generate(Bitmap picture, int noiseLevel)
        {
            int randomValue;

            Color pixel;

            for (var i = 0; i < PictureContainer.Size; i++)
            {
                for (var j = 0; j < PictureContainer.Size; j++)
                {
                    pixel = picture.GetPixel(i, j);

                    randomValue = Random.Next(0, 100);

                    if (randomValue <= noiseLevel)
                    {
                        picture.SetPixel(i, j, InvertPixel(pixel));
                    }
                }
            }

            return picture;
        }

        private static Color InvertPixel(Color pixel)
        {
            return Color.FromArgb(RGBMAX - pixel.R, RGBMAX - pixel.G, RGBMAX - pixel.B);
        }
    }
}