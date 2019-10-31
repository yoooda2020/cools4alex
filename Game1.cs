using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace cools4alex
{
    
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        Drawer   car,bar,track;
        public static event DlgDraw Event_Draw;
        public static event DlgUpdate Event_Update;



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferredBackBufferWidth = 1200;
         
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
            
        }

        protected override void Initialize()
        {

            IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.

            G.init(GraphicsDevice);
            track = new Drawer(Content.Load<Texture2D>("track"),
                       new Vector2(0,0),
                       null, Color.White, 0, new Vector2(0),
                       new Vector2(2), SpriteEffects.None, 0);

            car =new MovingObj (Content.Load<Texture2D>("car"),
                       new Vector2(300,200),
                       null,Color.White,0,new Vector2(87,65),
                       new Vector2(0.7f),SpriteEffects.FlipHorizontally,0);

            bar = new MovingObj(Content.Load<Texture2D>("car"),
                       new Vector2(200, 300),
                       null, Color.Yellow , 0, new Vector2(0),
                       new Vector2(0.5f), SpriteEffects.None , 0);
            
           

            new Drawer(Content.Load<Texture2D>("car"),
                       new Vector2(220, 400),
                       null, Color.Yellow, 0, new Vector2(0),
                       new Vector2(0.5f), SpriteEffects.None, 0);
           
            new Drawer(Content.Load<Texture2D>("car"),
                       new Vector2(320, 100),
                       null, Color.Red , 0, new Vector2(0),
                       new Vector2(0.5f), SpriteEffects.None, 0);

            new Drawer(Content.Load<Texture2D>("car"),
                       new Vector2(620, 400),
                       null, Color.Yellow, 0, new Vector2(0),
                       new Vector2(0.5f), SpriteEffects.None, 0);
            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            Event_Update?.Invoke();
          

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            G.sb.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
                null,null,null,null,
                Matrix.CreateTranslation(-car.Position.X,-car.Position.Y,0)*

                Matrix.CreateScale(1)*
                Matrix.CreateRotationZ(0)*
                Matrix.CreateTranslation(600,350,0));
            Event_Draw?.Invoke();
            G.sb.End();

            base.Draw(gameTime);
        }
    }
}
