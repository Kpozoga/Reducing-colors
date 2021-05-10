using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gk_zad3
{
    class Centroid
    {
        public List<pixel> pixels=new List<pixel>(1000);
        public struct pixel
        {
            public int x, y;
            public Color color;
            public pixel(int x,int y,Color c)
            {
                this.x = x;
                this.y = y;
                color = c;
            }
        }
        public Color color;
        public Centroid(Color c)
        {
            color = c;
        }
        public bool CalculateColor()
        {
            if (pixels.Count == 0) return false;
            int r=0, g=0, b=0;
            foreach(pixel p in pixels)
            {
                r += p.color.R;
                g += p.color.G;
                b += p.color.B;
            }
            r /= pixels.Count;
            g /= pixels.Count;
            b /= pixels.Count;
            if (r == color.R && g == color.G && b == color.B)
                return false;
            color = Color.FromArgb(r,g,b);
            return true;
        }
    }
}
