using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShooterGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Sprite background;
        private Sprite playerShip;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            background = new Sprite(Content.Load<Texture2D>("spacebackground"), Vector2.Zero);

            var shipTexture = Content.Load<Texture2D>("spaceship");
            var yPositionOfShip = graphics.GraphicsDevice.Viewport.Height - shipTexture.Height - 10;
            var xPositionOfShip = (graphics.GraphicsDevice.Viewport.Width / 2) - (shipTexture.Width / 2);

            playerShip = new Sprite(shipTexture, new Vector2(xPositionOfShip, yPositionOfShip));
        }

    
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

     
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            background.Draw(spriteBatch);
            playerShip.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
