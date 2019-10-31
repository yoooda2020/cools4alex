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
    class Drawer
    {
        #region data
        Texture2D texture;
        public Vector2 Position { get; set;}
        Rectangle? sourceRectangle;
        Color color;
        protected float Rotation;
        Vector2 origin;
        Vector2 scale;
        SpriteEffects effects;
        float layerDepth;
        #endregion
        #region ctor
        public Drawer()
        {

        }
        public Drawer(Texture2D texture, Vector2 position,
           Rectangle? sourceRectangle, Color color,
           float rotation, Vector2 origin, Vector2 scale,
           SpriteEffects effects, float layerDepth)
        {
            this.texture = texture;
            this.Position = position;
            this.sourceRectangle = sourceRectangle;
            this.color = color;
            this.Rotation = rotation;
            this.origin = origin;
            this.scale = scale;
            this.effects = effects;
            this.layerDepth = layerDepth;
            Game1.Event_Draw += draw;

        }

       
        #endregion
        #region funcs
         void draw()
        {
            G.sb.Draw(texture, Position, sourceRectangle,
                      color, Rotation, origin, scale,
                      effects, layerDepth);
        }
        #endregion
    }
}
