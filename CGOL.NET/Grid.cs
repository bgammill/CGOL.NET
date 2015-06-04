using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C3.XNA;

namespace CGOL.NET
{
    public class Grid
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int HeightRatio { get; private set; }
        public int WidthRatio { get; private set; }

        List<Element> elements = new List<Element>();

        public const int DIVISOR = 10;

        public Grid(int height, int width)
        {
            this.Height = height;
            this.Width = width;

            this.HeightRatio = height / DIVISOR;
            this.WidthRatio = width / DIVISOR;

            CreateElements();
        }

        private void CreateElements()
        {
            // row loop
            for (var i = 1; i <= DIVISOR; i++)
            {
                // column loop
                for (var j = 1; j <= DIVISOR; j++)
                {
                    elements.Add(new Element(new Vector2(i, j)));
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // draw columns
            for (var i = 1; i <= DIVISOR; i++)
            {
                Primitives2D.DrawLine(spriteBatch, new Vector2(WidthRatio * i, 0), new Vector2(WidthRatio * i, Height), Color.Black);
            }

            // draw rows
            for (var i = 1; i <= DIVISOR; i++)
            {
                Primitives2D.DrawLine(spriteBatch, new Vector2(0, HeightRatio * i), new Vector2(Width, HeightRatio * i), Color.Black);
            }
        }
    }
}

