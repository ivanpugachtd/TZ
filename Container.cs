using System;
using System.Drawing.Imaging;
using System.Drawing;

namespace ImageSobel
{
    public class BitmapContainer
    {
        public PixelFormat Format { get; }
        public int Width { get; }

        public int Height { get; }

        byte[] Buffer { get; }

        public BitmapContainer(Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            Format = bitmap.PixelFormat;
            Width = bitmap.Width;
            Height = bitmap.Height;
            Buffer = new byte[Height * Width];
        }

        public Bitmap ToBitmap()
        {
            return new Bitmap(Width, Height, Format);
        }
    }
}