using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Helpers
{
    public class ImageHelper
    {
        public static byte[] FromImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image FromByteToImage(byte[] image)
        {
                MemoryStream ms = new MemoryStream(image);
                return Image.FromStream(ms);
        }

        private static Exception Exception(string v)
        {
            throw new NotImplementedException();
        }
    }
}
