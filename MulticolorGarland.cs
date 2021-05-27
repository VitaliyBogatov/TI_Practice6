using System;
using System.Collections.Generic;

namespace TI_Prectice6
{
    public class MulticolorGarland : Garland <ColorLamp>
    {
        public MulticolorGarland(int count)
        {
            Lamps = new List<ColorLamp>(count);
            SetGarland(count);
        }

        protected override void SetGarland(int count)
        {
            int index = 1;

            while (index <= count)
            {
                ColorLamp lamp = new ColorLamp();
                bool isEven = index % 2 == 0;
                lamp.AddLamp(isEven, index);
                Lamps.Add(lamp);
                index++;
            }
        }

        public override void GetState()
        {
            base.GetState();

            Console.Write("\nMulticolor garland's state: ");
            foreach (ColorLamp lamp in Lamps)
            {
                if (lamp.IsTurned)
                {
                    switch (lamp.Color)
                    {
                        case ColorLamp.LampColor.Red:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('\u25cf');
                            break;
                        case ColorLamp.LampColor.Yellow:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write('\u25cf');
                            break;
                        case ColorLamp.LampColor.Green:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write('\u25cf');
                            break;
                        case ColorLamp.LampColor.Blue:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write('\u25cf');
                            break;
                    }
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
