using System.Collections.Generic;

namespace DesignPattern.Creation.Prototype
{
    /* [Prototype]
     * 
     * 1. 클래스 복사가 필요할때 사용.
     * 2. 복사하려는 클래스를 알지 못하더라도 복사를 하고 싶을때 사용.
     * 
     */

    #region Define

    /// <summary>
    /// Prototype Interface
    /// </summary>
    interface Prototype
    {
        Prototype Copy();
    }

    #endregion

    #region Using

    /// <summary>
    /// How to use Prototype?
    /// </summary>
    interface Car
    {
        Car Copy();
    }

    class KiaCar : Car
    {
        public Car Copy()
        {
            return new KiaCar();
        }
    }

    class HundaiCar : Car
    {
        public Car Copy()
        {
            return new KiaCar();
        }
    }

    /// <summary>
    /// Example
    /// </summary>
    class Main
    {
        void ActualSituation()
        {
            // 아주 잘 만든 기아차가 너무 좋아 동일한 걸 다시 만듬
            List<Car> cars = new List<Car>();

            KiaCar veryGoodCar = new KiaCar();
            cars.Add(veryGoodCar);

            Car copiedCar = veryGoodCar.Copy();
            cars.Add(copiedCar);
        }
    }

    #endregion
}
