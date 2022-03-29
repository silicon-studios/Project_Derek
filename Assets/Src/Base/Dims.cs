using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Base
{
    public class Dims
    {
        public Vector3 Vector => _vector;
        private Vector3 _vector;

        public float X
        {
            get => _vector.x;
            set => _vector.x = value;
        }
        public float Y
        {
            get => _vector.y;
            set => _vector.y = value;
        }
        public float Z
        {
            get => _vector.z;
            set => _vector.z = value;
        }

        public static implicit operator Dims((float x, float y, float z) value) => new Dims(value);

        public Dims((float x, float y, float z) value)
        {
            Setup(value.x, value.y, value.z);
        }

        public Dims(float x, float y, float z)
        {
            Setup(x, y, z);
        }

        public Dims(Vector3 vector)
        {
            _vector = vector;
        }

        private void Setup(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
