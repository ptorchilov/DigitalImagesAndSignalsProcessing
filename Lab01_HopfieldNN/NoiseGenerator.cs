// -----------------------------------------------------------------------
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
        /// Gets or sets the picture path.
        /// </summary>
        /// <value>
        /// The picture path.
        /// </value>
        public static String PicturePath { get; set; }

        /// <summary>
        /// Generates the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="noiseLevel">The noise level.</param>
        /// <param name="pictureSize">Size of the picture.</param>
        /// <returns></returns>
        public static String Generate(String path, int noiseLevel, int pictureSize)
        {
            var noisePicturePath = CreateNewPath();

            File.Copy(path, noisePicturePath);

            var picture = new PictureContainer(noisePicturePath, pictureSize);

            return Generate(picture, noiseLevel);
        }

        /// <summary>
        /// Generates the specified picture.
        /// </summary>
        /// <param name="picture">The picture.</param>
        /// <param name="noiseLevel">The noise level.</param>
        /// <returns></returns>
        private static String Generate(PictureContainer picture, int noiseLevel)
        {
            int randomValue;

            Color pixel;

            for (var i = 0; i < picture.Size; i++)
            {
                for (var j = 0; j < picture.Size; j++)
                {
                    pixel = picture.Picture.GetPixel(i, j);

                    randomValue = Random.Next(0, 100);

                    if (randomValue < noiseLevel)
                    {
                        picture.Picture.SetPixel(i, j, InvertPixel(pixel));
                    }
                }
            }

            var oldPicture = PicturePath;

            PicturePath = CreateNewPath();
            picture.Picture.Save(PicturePath);
            picture.Picture.Dispose();
            DeleteFile(oldPicture);

            return PicturePath;
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
        /// <returns></returns>
        private static String CreateNewPath()
        {
           PicturePath = String.Concat(PicturesPath.PathToNoiseFolder, Guid.NewGuid().ToString(), ".bmp");

           return PicturePath;
        }

        /// <summary>
        /// Deletes the file.
        /// </summary>
        /// <param name="path">The path.</param>
        private static void DeleteFile(String path)
        {
            File.Delete(path);
        }
    }
}