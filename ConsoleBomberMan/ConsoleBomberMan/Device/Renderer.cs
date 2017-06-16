using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBomberMan.Device
{
	class Renderer
	{
		public static Renderer instance {
			get {
				if (instance == null)
				{
					instance = new Renderer();
				}
				return instance;
			}
			private set {
				instance = value;
			}
		}



		private Renderer() {

		}

		/// <summary>
		/// 最終的にコンソールに出力するメソッド。
		/// </summary>
		public void DrawConsoleFinal() {

		}

		public void Draw() {

		}


	}
}
