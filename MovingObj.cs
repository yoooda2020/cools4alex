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
    class MovingObj:Drawer 
    {
        #region ctor
        public MovingObj(Texture2D texture, Vector2 position,
          Rectangle? sourceRectangle, Color color,
          float rotation, Vector2 origin, Vector2 scale,
          SpriteEffects effects, float layerDepth) :
           base(texture, position,
           sourceRectangle, color,
           rotation, origin, scale,
           effects, layerDepth)
        {
            Game1.Event_Update += update;
        } 
        #endregion

        private void update()
        {
            if (G.ks.IsKeyDown(Keys.Right ))
            {
                Rotation += 0.05f;
            }
            if (G.ks.IsKeyDown(Keys.Left ))
            {
                Rotation -= 0.05f;
            }
            if (G.ks.IsKeyDown(Keys.Up ))
            {
                Position += 10 * Vector2.Transform(Vector2.UnitX, Matrix.CreateRotationZ(Rotation));
                
            }
            if (G.ks.IsKeyDown(Keys.Down ))
            {
                Position -= 10*Vector2.Transform(Vector2.UnitX, Matrix.CreateRotationZ(Rotation));

            }
        }
    }
}
