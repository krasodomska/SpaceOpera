using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace SpaceOpera
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Dictionary<Mechanics.SkillName, Mechanics.Skill> skill = new Dictionary<Mechanics.SkillName, Mechanics.Skill>();
            skill.Add(Mechanics.SkillName.dodging, new Mechanics.Skill(4, 0));
            skill.Add(Mechanics.SkillName.piloting, new Mechanics.Skill(12, 0));
            List<Mechanics.Room> rooms = new List<Mechanics.Room>();
            rooms.Add(new Mechanics.Room(new object(), Mechanics.Size.L, new Mechanics.Module("Cargo", Mechanics.Size.L, new Dictionary<Mechanics.SkillName, int>(), 5, 0, 0)));
            rooms.Add(new Mechanics.Room(new object(), Mechanics.Size.L, new Mechanics.Module("Cargo", Mechanics.Size.L, new Dictionary<Mechanics.SkillName, int>(), 5, 0, 0)));



            Dictionary<Mechanics.SkillName, int> skillMod = new Dictionary<Mechanics.SkillName, int>();
            skillMod.Add(Mechanics.SkillName.dodging, 2);
            rooms.Add(new Mechanics.Room(new object(), Mechanics.Size.L, new Mechanics.Module("Cargo", Mechanics.Size.L, skillMod, 5, 0, 0)));

            Mechanics.Ship ship = new Mechanics.Ship("Alfa", new Mechanics.TriStepValue(10, 10, 10), 1000, skill, rooms);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
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

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
