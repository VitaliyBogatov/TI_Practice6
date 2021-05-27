namespace TI_Prectice6
{
    public class ColorLamp : Lamp
    {
        public enum LampColor
        {
            Red = 1,
            Yellow = 2,
            Green = 3,
            Blue = 4
        }

        public LampColor Color { get; set; }

        public void AddLamp(bool isEven, int index)
        {
            IsEven = isEven;

            switch (index % 4)
            {
                case 1:
                    Color = LampColor.Red;
                    break;
                case 2:
                    Color = LampColor.Yellow;
                    break;
                case 3:
                    Color = LampColor.Green;
                    break;
                case 0:
                    Color = LampColor.Blue;
                    break;
            }
        }
    }
}