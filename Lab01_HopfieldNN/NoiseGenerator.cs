﻿// -----------------------------------------------------------------------
// <copyright file="NoiseGenerator.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_HopfieldNN
{
    using System;
    using System.Drawing;
    using System.IO;

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
        private const int RGBMAX = 255;

        /// <summary>
        /// Generates the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="noiseLevel">The noise level.</param>
        /// <returns></returns>
        public static Bitmap Generate(String path, int noiseLevel)
        {
            var noisePicturePath = CreateNewPath(path);

            File.Copy(path, noisePicturePath);

            var picture = new Bitmap(noisePicturePath);

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

        /// <summary>
        /// Inverts the pixel.
        /// </summary>
        /// <param name="pixel">The pixel.</param>
        /// <returns></returns>
        private static Color InvertPixel(Color pixel)
        {
            return Color.FromArgb(RGBMAX - pixel.R, RGBMAX - pixel.G, RGBMAX - pixel.B);
        }

        /// <summary>
        /// Creates the new path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        private static String CreateNewPath(String path)
        {
            return String.Concat(PicturesPath.PathToNoiseFolder, Guid.NewGuid().ToString(), ".bmp");
        }
    }
}