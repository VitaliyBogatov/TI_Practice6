using System;

namespace TI_Prectice6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SetNumberOfLamps:

            Console.Write("Please specify an amount of lamps in the garland greater than 0: ");
            if (Int32.TryParse(Console.ReadLine(), out int counter))
            {
                if (counter > 0)
                {
                    MonochromeGarland monochromeGarland = new MonochromeGarland(counter);
                    monochromeGarland.GetState();

                    MulticolorGarland multicolorGarland = new MulticolorGarland(counter);
                    multicolorGarland.GetState();
                    Console.ReadKey();
                }
                else
                {
                    goto SetNumberOfLamps;
                }
            }
            else
            {
                goto SetNumberOfLamps;
            }
        }
    }
}