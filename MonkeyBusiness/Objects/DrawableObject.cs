using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MonkeyBusiness.Objects
{
    class DrawableObject
    {
        Texture2D texture;
        Vector2 position;
        int height, width;

        private bool isAnimated = false;
        private double animationInterval;

        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)position.X,
                    (int)position.Y,
                    this.width,
                    this.height);
            }
        }

        public DrawableObject(Texture2D texture, Vector2 position)
        {
            LoadTexture(texture);
            this.position = position;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!isAnimated)
                spriteBatch.Draw(texture, position, Color.White);
        }

        public void LoadTexture(Texture2D texture)
        {
            this.texture = texture;
        }
    }
}
