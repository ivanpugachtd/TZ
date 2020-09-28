using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;



namespace ImageSobel
{
    public class Test
    {
        public void imageCreate()
        {
            string inputFile = @"C:\Users\Ivan\Pictures\test.jpg";
            string outputFile = @"C:\Users\Ivan\Pictures\test2.jpg";

            Bitmap bmp = Bitmap.FromFile(inputFile) as Bitmap;
            bmp = bmp.Sobel3x3Filter();

            /*var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8; //bytes per pixel

            var buffer = new byte[data.Width * data.Height * depth];

            //copy pixels to buffer
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);*/

            /*Parallel.Invoke(
                () => {
                    //upper-left
                    Process(buffer, 0, 0, data.Width / 2, data.Height / 2, data.Width, depth);
                },
                () => {
                    //lower-right
                    Process(buffer, data.Width / 2, data.Height / 2, data.Width, data.Height, data.Width, depth);
                },
                () => {
                    //lower-right
                    Process(buffer, 0, data.Height / 2, data.Width, data.Height, data.Width, depth);
                },
                () => {
                    //lower-right
                    Process(buffer, data.Width / 2, 0, data.Width, data.Height, data.Width, depth);
                }
            );*/

            

            //Copy the buffer back to image
            //Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);

            //bmp.UnlockBits(data);

            bmp.Save(outputFile, ImageFormat.Jpeg);
        }
    }
}