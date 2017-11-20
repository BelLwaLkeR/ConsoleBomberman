using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleBomberMan.Extends;

namespace ConsoleBomberMan.Utility
{
	class Vector2
	{
		public int x;
		public int y;

		public Vector2() {
			x = 0;
			y = 0;
		}

		public Vector2(int x, int y) {
			this.x = x;
			this.y = y;
		}

        public Vector2(float x, float y) {
			this.x = x.Round();
			this.y = y.Round();
		}

		public static Vector2 Zero {
			get
			{
				return new Vector2(0, 0);
			}
		}
		public static Vector2 One {
			get
			{
				return new Vector2(1, 1);
			}

		}

		public static Vector2 Up {
			get
			{
				return new Vector2(0, -1);
			}
		}

		public static Vector2 Down {
			get
			{
				return new Vector2(0, 1);
			}
		}

		public static Vector2 Left {
			get {
				return new Vector2(-1,0);
			}
		}

		public static Vector2 Right {
			get
			{
				return new Vector2(1,0);
			}
		}

        public static bool operator ==(Vector2 value1, Vector2 value2) {
            return value1.x == value2.x && value1.y == value2.y;
        }

        public static bool operator !=(Vector2 value1, Vector2 value2) {
            return !(value1==value2);
        }

        public static Vector2 operator +(Vector2 value1, Vector2 value2) {
            return new Vector2(value1.x+value2.x, value1.y+value2.y);
        }
        public static Vector2 operator -(Vector2 value1, Vector2 value2) {
            return new Vector2(value1.x-value2.x, value1.y-value2.y);
        }
        public static Vector2 operator *(Vector2 value1, Vector2 value2) {
            return new Vector2(value1.x+value2.x, value1.y+value2.y);
        }
        public static Vector2 operator *(Vector2 value1, float value2) {
            return new Vector2(value1.x*value2, value1.y*value2);
        }
        public static Vector2 operator /(Vector2 value1, Vector2 value2) {
            return new Vector2(value1.x/value2.x, value1.y/value2.y);
        }
        public static Vector2 operator /(Vector2 value1, float value2) {
            return new Vector2(value1.x/value2, value1.y/value2);
        }
	}
}
