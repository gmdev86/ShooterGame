using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShooterGame
{
    internal class Sprite
    {
        private readonly Texture2D texture;
        private readonly Vector2 position;

        public Sprite(Texture2D texture2D, Vector2 position)
        {
            this.texture = texture2D;
            this.position = position;
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}