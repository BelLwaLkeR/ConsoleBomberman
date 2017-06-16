using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBomberMan.Utility
{
	class Vector2
	{
		public float x;
		public float y;

		public Vector2() {
			x = 0;
			y = 0;
		}

		public Vector2(float x, float y) {
			this.x = x;
			this.y = y;
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


	}
}
