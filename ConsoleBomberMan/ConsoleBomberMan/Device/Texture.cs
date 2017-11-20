using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleBomberMan.Utility;

namespace ConsoleBomberMan.Device
{
    class Texture
    {
        public string       text;
        public Vector2      position;
        public ConsoleColor textColor;
        public ConsoleColor backColor;

        public Texture(string text, Vector2 position, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backColor = ConsoleColor.Black)
        {
            this.text = text;
            this.position = position;
            this.textColor = textColor;
            this.backColor = backColor;
            
        }
    }
}
