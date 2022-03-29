using Assets.Src.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src
{
    public class WorldObject
    {
        public Dims Position;
        public Dims Hitbox;
        public GameObject GameObject { get; private set; }

        public WorldObject(Dims pos, Dims hit)
        {
            Position = pos;
            Hitbox = hit;

            GameObject = new GameObject();
            GameObject.transform.localScale = new Vector3(0, 0, 0);
        }

        public void Render()
        {
            GameObject.transform.position = Position.Vector;
            GameObject.transform.localScale = Hitbox.Vector;
        }
    }
}
