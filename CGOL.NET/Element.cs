using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGOL.NET
{
    public class Element
    {
        public Vector2 Position { get; private set; }

        public Element(Vector2 position)
        {
            this.Position = position;
        }

        public Element(float x, float y)
        {
            this.Position = new Vector2(x, y);
        }
    }
}
