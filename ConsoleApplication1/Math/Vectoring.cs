namespace ExternalBase.C0re.Math
{
    class Vectoring
    {
        public struct Vector3
        {
            public float x;
            public float y;
            public float z;

            public Vector3(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public static Vector3 operator +(Vector3 v1, Vector3 v2)
            {
                return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            }

            public static Vector3 operator -(Vector3 v1, Vector3 v2)
            {
                return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
            }

            public float dot(Vector3 dot)
            {
                return (x * dot.x + y * dot.y + z * dot.z);
            }

            public float VectorDistance(Vector3 l, Vector3 e)
            {
                return (float)System.Math.Sqrt(System.Math.Pow(l.x - e.x, 2) + System.Math.Pow(l.y - e.y, 2) + System.Math.Pow(l.z - e.z, 2));
            }

            public Vector3 VectorClone()
            {
                return new Vector3(this.x, this.y, this.z);
            }
        }

        public struct Vector2
        {
            public float x;
            public float y;

            public Vector2(float x, float y)
            {
                this.x = x;
                this.y = y;
            }

            public static Vector2 operator +(Vector2 v1, Vector2 v2)
            {
                return new Vector2(v1.x + v2.x, v1.y + v2.y);
            }

            public static Vector2 operator -(Vector2 v1, Vector2 v2)
            {
                return new Vector2(v1.x - v2.x, v1.y - v2.y);
            }

            public float dot(Vector2 dot)
            {
                return (x * dot.x + y * dot.y);
            }

            public Vector2 VectorClone()
            {
                return new Vector2(this.x, this.y);
            }
        }
    }
}
