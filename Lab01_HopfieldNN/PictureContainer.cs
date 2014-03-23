// -----------------------------------------------------------------------
// <copyright file="PictureContainer.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_HopfieldNN
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Class for store pirtures in bitmap
    /// </summary>
    public class PictureContainer
    {
        /// <summary>
        /// Gets the picture.
        /// </summary>
        /// <value>
        /// The picture.
        /// </value>
        public Bitmap Picture { get; private set; }

        /// <summary>
        /// The size of picture
        /// </summary>
        public const int Size = 13;

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureContainer"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public PictureContainer(String path)
        {
            Picture = new Bitmap(path);
        }
    }
}
