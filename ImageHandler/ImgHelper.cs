using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace ImageHandler
{
    public static class ImgHelper
    {

        public static byte[] ResizeImage(string path, int width, int height)
        {
            Bitmap imgIn = new Bitmap(path);
            double y = imgIn.Height;
            double x = imgIn.Width;

            double factor = 1;
            if (width > 0)
            {
                factor = width / x;
            }
            else if (height > 0)
            {
                factor = height / y;
            }
            System.IO.MemoryStream outStream =
            new System.IO.MemoryStream();
            Bitmap imgOut =
            new Bitmap((int)(x * factor), (int)(y * factor));
            Graphics g = Graphics.FromImage(imgOut);
            g.Clear(Color.White);
            g.DrawImage(imgIn, new Rectangle(0, 0, (int)(factor * x),
            (int)(factor * y)),
            new Rectangle(0, 0, (int)x, (int)y), GraphicsUnit.Pixel);

            imgOut.Save(outStream, getImageFormat(path));
            return outStream.ToArray();

        }
        public static string getContentType(string path)
        {
            switch (Path.GetExtension(path))
            {
                case ".bmp":return "Image/bmp";
                case ".gif":return "Image/gif";
                case ".jpg":return "Image/jpeg";
                case ".png":return "Image/png";
                default:break;
            }
            return "";
        }
        public static ImageFormat getImageFormat(String path)
        {
            switch (Path.GetExtension(path))
            {
                case ".bmp":return ImageFormat.Bmp;
                case ".gif":return ImageFormat.Gif;
                case ".jpg":return ImageFormat.Jpeg;
                case ".png":return ImageFormat.Png;
                default: break;
            }
            return ImageFormat.Jpeg;
        }
    }
}