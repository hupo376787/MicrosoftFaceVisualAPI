using System.Drawing;
using System.IO;
using System.Net;

namespace FaceAPI
{
    class ImageHelper
    {
        public static byte[] SetImageToByteArray(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            int streamLength = (int)fs.Length;
            byte[] image = new byte[streamLength];
            fs.Read(image, 0, streamLength);
            fs.Close();
            return image;
        }

        public static Image UrlToImage(string url)
        {
            WebClient mywebclient = new WebClient();
            byte[] Bytes = mywebclient.DownloadData(url);
            using (MemoryStream ms = new MemoryStream(Bytes))
            {
                Image outputImg = Image.FromStream(ms);
                return outputImg;
            }
        }
    }
}
