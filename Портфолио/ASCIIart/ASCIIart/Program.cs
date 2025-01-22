using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Configuration;


namespace ASCIIart
{
    

    internal class Program
    {
        private const double V = 1.5;
        private const int MAX_WIDTH = 500;


        [STAThread]
        static void Main(string[] args)
        {

            var openfolder = new OpenFileDialog
            {
                Filter = "Image | *.bmp; *.png; *.jpg; *.JPEG"
            };





            while (true)
            {
                Console.ReadLine();

                if (openfolder.ShowDialog() != DialogResult.OK)
                {
                    continue;
                }
                Console.Clear();

                var bitmap = new Bitmap(openfolder.FileName);

                bitmap = ResizeBitmap(bitmap);
                bitmap.ToGrayscale();

                var convert = new BitmapConvertASCII(bitmap);

                var rows = convert.Convert();


                foreach (var row in rows)
                {
                    Console.WriteLine(row);
                }

                File.WriteAllLines("image.txt", rows.Select(r => new string(r)));
                Console.SetCursorPosition(0, 0);

            }



        }

        private static Bitmap ResizeBitmap(Bitmap bmp)
        {

            var newHeight = bmp.Height / V * MAX_WIDTH / bmp.Width;
            if (bmp.Width > MAX_WIDTH || bmp.Height > newHeight)
            {
                bmp = new Bitmap(bmp, new Size(MAX_WIDTH, (int)newHeight));

            }
            return bmp;
        }


    }
}