using System.Drawing;
using System.Drawing.Imaging;

namespace ManipuladorImagens
{
    public class LenticularImage
    {
        public static void CreateLenticularImage(string imagemFundo, string image, string outputPath, int lpi)
        {
            using (Bitmap image1 = new Bitmap(imagemFundo))
            using (Bitmap image2 = new Bitmap(image))
            {
                int width = image1.Width;
                int height = image1.Height;

                using (Bitmap lenticularImage = new Bitmap(width, height))
                {
                    int linesPerInch = lpi;
                    int linesPerPixel = width / linesPerInch;

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Color color;
                            if (x / linesPerPixel % 2 == 0)
                            {
                                color = image1.GetPixel(x, y);
                            }
                            else
                            {
                                color = image2.GetPixel(x, y);
                            }
                            lenticularImage.SetPixel(x, y, color);
                        }
                    }
                    lenticularImage.Save(outputPath);
                }
            }
        }
    }
}