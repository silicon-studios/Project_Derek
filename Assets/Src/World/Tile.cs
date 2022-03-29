using Assets.Src.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.World
{
    public class Tile : WorldObject
    {
        public Tile(Dims pos) : base(pos, (GameSettings.Default.TileWidth, GameSettings.Default.TileHeight, GameSettings.Default.TileLength))
        {

        }
    }
}
