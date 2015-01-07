using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameStateManager;
using Microsoft.Xna.Framework;
using MonkeyBusiness.Objects;

namespace MonkeyBusiness.MiniGames
{
    class Level01 : MiniGame
    {
        private Texture2D SpriteTexture;

        public Monkey(Manager manager) : base(manager)
        {

        }
        public override void Initialize() { }
        public override void Draw(GameTime gameTime)
        {
            GetGraphicDevice();
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            Vector2 pos = new Vector2(100, 100);
            spriteBatch.Draw(SpriteTexture, pos, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
        public override void Update(GameTime gameTime) { }
        public override void LoadContent()
        {
            SpriteTexture = Content.Load<Texture2D>("monkey");
        }
        public override void UnloadContent() { }
    }
}
