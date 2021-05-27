using System;
using System.Collections.Generic;

namespace TI_Prectice6
{
    public class MonochromeGarland : Garland <Lamp>
    {
        public MonochromeGarland(int count)
        {
            Lamps = new List<Lamp>(count);
            base.SetGarland(count);
        }

        public override void GetState()
        {
            base.GetState();

            Console.Write("\nMonochrome garland's state: ");
            foreach (Lamp lamp in Lamps)
            {
                if (lamp.IsTurned)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('\u25cf');
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write('\u25cf');
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
