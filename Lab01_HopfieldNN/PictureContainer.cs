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
        public int Size { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureContainer" /> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="size">The size.</param>
        public PictureContainer(String path, int size)
        {
            Picture = new Bitmap(path);
            Size = size;
        }
    }
}