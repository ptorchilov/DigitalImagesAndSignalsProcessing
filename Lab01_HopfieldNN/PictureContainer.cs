// -----------------------------------------------------------------------
// <copyright file="PictureContainer.cs" company="BSUIR">
// Pavel Torchilov
// </copyright>
// -----------------------------------------------------------------------

namespace Lab01_HopfieldNN
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class for store pirtures in bitmap
    /// </summary>
    public class PictureContainer
    {
        public Bitmap Picture { get; private set; }

        public PictureContainer(String path)
        {
            Picture = new Bitmap(path);
        }
    }
}
