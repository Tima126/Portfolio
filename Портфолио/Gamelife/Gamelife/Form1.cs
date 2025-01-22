using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gamelife
{
    public partial class Form1 : Form
    {
        private int curentGener = 0;
        private Graphics graphic;
        private int resolution;
        private bool[,] filed;
        private int rows;
        private int columns;

        public Form1()
        {
            InitializeComponent();

        }



        private void StartGame()
        {
            if (timer1.Enabled)
            {
                return;
            }
            curentGener = 0;
            Text = $"Generation {curentGener}";

            numResult.Enabled = false;
            numDensiti.Enabled = false;

            resolution = (int)numResult.Value;

            rows = pictureBox1.Height / resolution;
            columns = pictureBox1.Width / resolution;

            filed = new bool[columns, rows];


            Random rnd = new Random();

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    filed[x, y] = rnd.Next((int)numDensiti.Value) == 0;

                }
            }


            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphic = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();

        }


        private void NextGenerete()
        {
            graphic.Clear(Color.Black);

            var newfild = new bool[columns, rows];

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neigboursCount = CountNeigbor(x, y);
                    var haslife = filed[x, y];

                    if (!haslife && neigboursCount == 3)
                    {
                        newfild[x, y] = true;
                    }
                    else if (haslife && (neigboursCount < 2 || neigboursCount > 3))
                    {
                        newfild[x, y] = false;
                    }
                    else
                    {
                        newfild[x, y] = filed[x, y];
                    }
                    if (haslife)
                    {
                        graphic.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
                    }

                }
            }
            Text = $"Generation {++curentGener}";
            filed = newfild;
            pictureBox1.Refresh();

        }






        private int CountNeigbor(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++) 
                {
                    if (i == 0 && j == 0) 
                        continue;

                    var col = (x + i + columns) % columns;
                    var row = (y + j + rows) % rows; 
                    var haslife = filed[col, row];
                    if (haslife)
                    {
                        count++;
                    }
                }
            }

            return count;
        }


        private void StopGame()
        {
            if (!timer1.Enabled)
            {
                return;
            }
            else
            {
                timer1.Stop();
                numResult.Enabled = true;
                numDensiti.Enabled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGenerete();
        }

        private void ButStart_Click(object sender, EventArgs e)
        {

            StartGame();



        }

        private void ButStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
            return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validat = Validatmousepos(x, y);
                if (validat)
                {
                    filed[x, y] = true;
                }
                
            }


            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validat = Validatmousepos(x, y);
                if (validat)
                {
                    filed[x, y] = false;
                }
            }


        }

        private bool Validatmousepos(int x, int y)
        {
            return x>=0 && y>=0 && x< columns && y<rows;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Generation {curentGener}";
        }
    }
}
