using System;
using System.Collections.Generic;
using System.Linq;

namespace TI_Prectice6
{
    public abstract class Garland<T> where T : Lamp, new()
    {
        protected virtual List<T> Lamps { get; set; }

        protected virtual void SetGarland(int count)
        {
            int index = 1;

            while (index <= count)
            {
                T lamp = new T();
                bool isEven = index % 2 == 0;
                lamp.AddLamp(isEven);
                Lamps.Add(lamp);
                index++;
            }
        }
        public virtual void GetState()
        {
            DateTime currentDateTime = DateTime.Now;
            int minute = currentDateTime.Minute;
            bool isEven = minute % 2 == 0;

            foreach (Lamp lamp in Lamps.Where(lamp => lamp.IsEven == isEven))
            {
                lamp.IsTurned = true;
            }

            foreach (Lamp lamp in Lamps.Where(lamp => lamp.IsEven == !isEven))
            {
                lamp.IsTurned = false;
            }
        }
    }
}
