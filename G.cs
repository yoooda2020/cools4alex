using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace cools4alex
{

    static class G
    {
        public static SpriteBatch sb;
        public static KeyboarddState ks;

        public static void init(GraphicsDevice gd)
        {
            sb = new SpriteBatch(gd);
            Game1.Event_Update += update;
        }

        static void update()
        {
            ks = Keyboard.GetState();
        }
    }
}
