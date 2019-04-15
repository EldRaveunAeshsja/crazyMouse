using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CrazyMouse.States
{
    public class GameState : State
    {
        private float _angle = 0;

        public GameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            int milieu = 935;
            int backgroundWwidth = milieu;
            int backgroundHeiht = milieu;

            Vector2 location = new Vector2(400, 240);
            Rectangle sourceRectangle = new Rectangle(0, 0, backgroundWwidth, backgroundHeiht);
            Vector2 origin = new Vector2(backgroundWwidth / 2, backgroundHeiht / 2);

            spriteBatch.Draw(_background, location, sourceRectangle, Color.White, _angle, origin, 1.0f, SpriteEffects.None, 1);

            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            _angle += 0.01f;
        }
    }
}
