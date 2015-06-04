using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGOL.NET
{
    public class Sprite
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public string Asset { get; set; }

        public Sprite(string asset)
        {
            this.Asset = asset;
        }

        public virtual void LoadContent(ContentManager contentManager)
        {
            this.Texture = contentManager.Load<Texture2D>(this.Asset);
        }

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
            spriteBatch.End();
        }

        public virtual void Update(GameTime gameTime)
        {

        }
    }
}
