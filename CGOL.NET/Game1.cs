using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using C3.XNA;

namespace CGOL.NET
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Grid grid;

        Vector2 mouseLocation;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            var currentDisplayMode = GraphicsDevice.Viewport;
            grid = new Grid(currentDisplayMode.Height, currentDisplayMode.Width);

            mouseLocation = new Vector2(0, 0);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // check mouse and keyboard for input
            GetInputDevices();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            // draw the grid
            grid.Draw(spriteBatch);

            // draw a test element
            //var testElement = new Element(5, 5);
            //var centerPoint = grid.GetPoint(testElement);
            //Primitives2D.DrawCircle(spriteBatch, centerPoint, 5.0f, 1, Color.Red);
            //Primitives2D.DrawRectangle(spriteBatch, new Rectangle((int)centerPoint.X, (int)centerPoint.Y, grid.WidthRatio, grid.HeightRatio), Color.Red);

            // draw a box around the mouse location
            Primitives2D.DrawRectangle(spriteBatch, new Rectangle((int)mouseLocation.X, (int)mouseLocation.Y, 5, 5), Color.Red);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Wrapper for getting keyboard and mouse input.
        /// </summary>
        protected void GetInputDevices()
        {
            GetMouseInput();
            GetKeyboardInput();
        }

        /// <summary>
        /// Gets and updates mouse input.
        /// </summary>
        protected void GetMouseInput()
        {
            var mouseState = Mouse.GetState();
            mouseLocation = new Vector2(mouseState.X, mouseState.Y);
        }

        /// <summary>
        /// Gets keyboard input.
        /// </summary>
        protected void GetKeyboardInput()
        {
            var keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Escape))
            {
                Exit();
            }
        }
    }
}
