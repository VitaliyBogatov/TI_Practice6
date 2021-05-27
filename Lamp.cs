namespace TI_Prectice6
{
    public class Lamp
    {
        public bool IsEven { get; set; }
        public bool IsTurned { get; set; }
        public void AddLamp(bool isEven) => IsEven = isEven;
    }
}
