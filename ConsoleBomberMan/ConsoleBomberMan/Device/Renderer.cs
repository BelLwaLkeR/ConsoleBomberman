using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleBomberMan.Utility;

namespace ConsoleBomberMan.Device
{
	class Renderer
	{
        private List<Texture> textures;

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
            textures.ForEach(t=> {
                if(t.textColor != Console.ForegroundColor) { Console.ForegroundColor = t.textColor; }
                if(t.backColor != Console.BackgroundColor) { Console.ForegroundColor = t.backColor; }
                Console.CursorLeft = t.position.x;
                Console.CursorTop = t.position.y;
                Console.Write(t.text);
            } );
            textures.Clear();
		}

        public void ClearConsole(){
            Console.Clear();
        }

		public void Draw(string text, Vector2 position, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backColor = ConsoleColor.Black) {
            Draw(new Texture(text, position, textColor, backColor));
		}

        public void Draw(Texture texture){
            textures.Add(texture);
        }


	}
}
