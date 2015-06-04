﻿using Microsoft.Xna.Framework;
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

        public const int DIVISOR = 100;

        public Grid(int height, int width)
        {
            this.Height = height;
            this.Width = width;

            this.HeightRatio = height / DIVISOR;
            this.WidthRatio = width / DIVISOR;
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
                //Primitives2D.DrawLine(spriteBatch, new Vector2(WidthRatio * i, 0), new Vector2(WidthRatio * i, Height), Color.Black);
            }
        }
    }
}