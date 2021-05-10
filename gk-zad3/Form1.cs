using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gk_zad3
{
    public partial class Form1 : Form
    {
        public DirectBitmap picture;
        string pictureName = "lena.png";
        public Form1()
        {
            InitializeComponent();
        }
        public void CreateClearBitmap(int width, int height)
        {
            pictureBox1.Image = new Bitmap(width, height);
            Graphics flagGraphics = Graphics.FromImage(pictureBox1.Image);
            flagGraphics.FillRectangle(Brushes.White, 0, 0, width, height);
            flagGraphics.DrawImage(pictureBox1.Image, width, height);
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap tmp= new Bitmap(System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName + "\\Sample Pictures\\" + pictureName);
            picture = new DirectBitmap(tmp.Width, tmp.Height);
            picture.ReproducePicture(tmp);
            pictureBox1.Image = new Bitmap(picture.Bitmap, pictureBox1.Width, pictureBox1.Height);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(picture.Bitmap, pictureBox1.Width, pictureBox1.Height);
        }

        private void loadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName + "\\Sample Pictures";
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureName = fileDialog.SafeFileName;
                Bitmap tmp = new Bitmap(fileDialog.FileName);
                picture = new DirectBitmap(tmp.Width, tmp.Height);
                picture.ReproducePicture(tmp);
                pictureBox1.Image = new Bitmap(picture.Bitmap, pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void fullResButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this,picture.Bitmap);
            form.Text = pictureName + " - original resolution";
            form.Show();
        }

        private void reduceColorsButton_Click(object sender, EventArgs e)
        {
            DirectBitmap reducedPicture = new DirectBitmap(picture.Width, picture.Height);
            reducedPicture.ReproducePicture(picture.Bitmap);
            int kr = (int)krNumeric.Value;
            int kg = (int)kgNumeric.Value;
            int kb = (int)kbNumeric.Value;
            string method = "";
            if (errorDiffusionButton.Checked)
            {
                method = errorDiffusionButton.Text;
                float[,] filter = new float[,] {
                {0, 0, 1/16.0f },
                {3/16.0f, 5/16.0f, 1/16.0f }
            };
                int fx = (filter.GetLength(0) - 1), fy = (filter.GetLength(1) - 1) / 2;
                for (int y = 0; y < picture.Height; y++)
                    for (int x = 0; x < picture.Width; x++)
                    {
                        Color originalColor = reducedPicture.GetPixel(x, y);
                        Color approxedColor = Approximate(originalColor, kr, kg, kb);
                        reducedPicture.SetPixel(x, y, approxedColor);
                        (float r, float g, float b) error = (originalColor.R - approxedColor.R,
                            originalColor.G - approxedColor.G,
                            originalColor.B - approxedColor.B);

                        for (int i = -fx; i <= fx; i++)
                            for (int j = 0; j <= fy; j++)
                            {
                                if (y + j >= picture.Height) continue;
                                if (x + i < 0) continue;
                                if (x + i >= picture.Width) continue;

                                Color tmp = reducedPicture.GetPixel(x + i, y + j);
                                int r = (int)(tmp.R + error.r * filter[j, i + fx]);
                                int g = (int)(tmp.G + error.g * filter[j, i + fx]);
                                int b = (int)(tmp.B + error.b * filter[j, i + fx]);

                                if (r < 0) r = 0;
                                if (g < 0) g = 0;
                                if (b < 0) b = 0;
                                if (r > 255) r = 255;
                                if (g > 255) g = 255;
                                if (b > 255) b = 255;

                                reducedPicture.SetPixel(x + i, y + j, Color.FromArgb(r, g, b));
                            }
                    }
            }
           
            else if (popularityAlgButton2.Checked)
            {
                method = popularityAlgButton2.Text;
                Dictionary<Color, int> dic = new Dictionary<Color, int>();
                for (int y = 0; y < picture.Height; y++)
                    for (int x = 0; x < picture.Width; x++)
                    {
                        Color c = reducedPicture.GetPixel(x, y);
                        if (dic.ContainsKey(c))
                            dic[c]++;
                        else dic.Add(c, 1);

                    }
                var tmp = dic.ToList();
                tmp.Sort((KeyValuePair<Color, int> a, KeyValuePair<Color, int> b) => { return b.Value - a.Value; });

                var tabR = tmp.Take(kr).Select(c => c.Key.R).ToList();
                tabR.Sort();

                var tabG = tmp.Take(kg).Select(c => c.Key.G).ToList();
                tabG.Sort();

                var tabB = tmp.Take(kb).Select(c => c.Key.B).ToList();
                tabB.Sort();

                for (int y = 0; y < picture.Height; y++)
                    for (int x = 0; x < picture.Width; x++)
                        reducedPicture.SetPixel(x, y, ApproximatePopular(
                            reducedPicture.GetPixel(x, y), tabR.ToArray(), tabG.ToArray(), tabB.ToArray()));
            }
            else if (popularityAlgButton.Checked)
            {
                method = popularityAlgButton.Text;
                Dictionary<Color, int> dic = new Dictionary<Color, int>();
                for (int y = 0; y < picture.Height; y++)
                    for (int x = 0; x < picture.Width; x++)
                    {
                        Color c = reducedPicture.GetPixel(x, y);
                        if (dic.ContainsKey(c))
                            dic[c]++;
                        else dic.Add(c, 1);

                    }
                var tmp = dic.ToList();
                tmp.Sort((KeyValuePair<Color, int> a, KeyValuePair<Color, int> b) => { return b.Value - a.Value; });

                var listColors = tmp.Take(kr).Select(c => c.Key).ToList();

                for (int y = 0; y < picture.Height; y++)
                    for (int x = 0; x < picture.Width; x++)
                    {
                        int distMin = int.MaxValue;
                        Color col = Color.Black;
                        Color orgColor = reducedPicture.GetPixel(x, y);
                        foreach (Color c in listColors)
                        {
                            int dist;
                            if ((dist = (c.R - orgColor.R) * (c.R - orgColor.R) +
                               (c.G - orgColor.G) * (c.G - orgColor.G) +
                               (c.B - orgColor.B) * (c.B - orgColor.B)) < distMin)
                            {
                                distMin = dist;
                                col = c;
                            }

                        }
                        reducedPicture.SetPixel(x, y, col);
                    }
            }
            else if (kmeansAlgButton.Checked)
            {
                method = kmeansAlgButton.Text;
                Random rand = new Random();
                List<Centroid> centroids = new List<Centroid>(kr);
                for(int i=0;i<kr;i++)
                    centroids.Add(new Centroid(picture.GetPixel(rand.Next(picture.Width),rand.Next(picture.Height))));
                bool centroidsChanged;
                int count = 0,max_i=100;
                do
                {
                    foreach (var c in centroids)
                        c.pixels.Clear();
                    for (int y = 0; y < picture.Height; y++)
                        Parallel.For(0, picture.Width, x => 
                        //for (int x = 0; x < picture.Width; x++)
                        {
                            int distMin = int.MaxValue;
                            Centroid cen = null;
                            Color orgColor = reducedPicture.GetPixel(x, y);
                            foreach (var c in centroids)
                            {
                                int dist;
                                if ((dist = (c.color.R - orgColor.R) * (c.color.R - orgColor.R) +
                                   (c.color.G - orgColor.G) * (c.color.G - orgColor.G) +
                                   (c.color.B - orgColor.B) * (c.color.B - orgColor.B)) < distMin)
                                {
                                    distMin = dist;
                                    cen = c;
                                }

                            }
                            cen.pixels.Add(new Centroid.pixel(x, y, picture.GetPixel(x, y)));
                        });
                    centroidsChanged = false;

                        foreach (var c in centroids)
                        if (c.CalculateColor())
                            centroidsChanged = true;
 
                    count++;
                } while (centroidsChanged && count < max_i);

                foreach (var c in centroids)
                    foreach (Centroid.pixel p in c.pixels)
                        reducedPicture.SetPixel(p.x, p.y, c.color);
            }
            Form2 form = new Form2(this,reducedPicture.Bitmap);
            if(popularityAlgButton.Checked||kmeansAlgButton.Checked)
                form.Text = pictureName + " - " + method + $" (k = {kr})";
            else
                form.Text = pictureName + " - "+method+$" (kr={kr}, kg={kg}, kb={kb})";
            form.Show();
        }

        private Color Approximate(Color c,int kr, int kg, int kb)
        {
            int r,g,b;           
            r = (int)(Math.Round(c.R * (kr - 1) / 255.0f) * 255 / (kr - 1));
            g = (int)(Math.Round(c.G * (kg - 1) / 255.0f) * 255 / (kg - 1));
            b = (int)(Math.Round(c.B * (kb - 1) / 255.0f) * 255 / (kb - 1));
            if (kr == 1) r = 255 / 2;
            if (kg == 1) g = 255 / 2;
            if (kb == 1) b = 255 / 2;
            return Color.FromArgb(r, g, b);
        }
        private Color ApproximatePopular(Color c, byte[] kr, byte[] kg, byte[] kb)
        {
            int r, g, b;
            int Calc(byte[] tab, byte n,int left,int right)
            {
                if (left == 0 && n < tab[left]) return tab[left];
                if (right == tab.Length - 1 && n > tab[right]) return tab[right];
                if (left >= right) return -1;
                if (tab[right] < n) return -1;
                if (tab[left] > n) return -1;
                int m = -1;
                if (left == right - 1)
                    if (tab[right] - n < n - tab[left])
                        return tab[right];
                    else
                        return tab[left];
                m = Calc(tab, n, left, right-(right-left)/2);
                if (m >= 0) return m;
                m = Calc(tab, n, left+(right-left)/2, right);
                return m;
            }
            r = Calc(kr, c.R, 0, kr.Length - 1);
            g = Calc(kg, c.G, 0, kg.Length - 1);
            b = Calc(kb, c.B, 0, kb.Length - 1);
            return Color.FromArgb(r, g, b);
        }

        private void popularityAlgButton_Click(object sender, EventArgs e)
        {
            kgNumeric.Enabled = false;
            kbNumeric.Enabled = false;
            krLabel.Text = "K";
        }

        private void kmeansAlgButton_CheckedChanged(object sender, EventArgs e)
        {
            kgNumeric.Enabled = false;
            kbNumeric.Enabled = false;
            krLabel.Text = "K";
        }

        private void errorDiffusionButton_CheckedChanged(object sender, EventArgs e)
        {
            kgNumeric.Enabled = true;
            kbNumeric.Enabled = true;
            krLabel.Text = "KR";
        }

        private void popularityAlgButton2_CheckedChanged(object sender, EventArgs e)
        {
            kgNumeric.Enabled = true;
            kbNumeric.Enabled = true;
            krLabel.Text = "KR";
        }

        private void toGrayscaleButton_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/21527518/converting-rgb-images-to-grayscale
            for (int x = 0; x < picture.Width; x++)
                for (int y = 0; y < picture.Height; y++)
                {
                    Color pixelColor = picture.GetPixel(x, y);
                    //  0.3 · r + 0.59 · g + 0.11 · b
                    int grey = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    picture.SetPixel(x, y, Color.FromArgb(pixelColor.A, grey, grey, grey));
                }
            pictureBox1.Image = new Bitmap(picture.Bitmap, pictureBox1.Width, pictureBox1.Height);
        }
    }
}
