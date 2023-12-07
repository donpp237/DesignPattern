namespace DesignPattern.Creation.FactoryMethod
{
    /* [Factory Method]
   * 
   * 1. 자식 클래스에서 객체를 생성 할 수 있도록 권한 위임.
   * 
   */

    #region Define

    /// <summary>
    /// Factory Method Interface
    /// </summary>
    interface FactoryMethod
    {
        object Create();
    }

    #endregion

    #region Using

    /// <summary>
    /// How to use Factory Method?
    /// </summary>
    interface Farm
    {
        Fruit Create();
    }

    class AppleFarm : Farm
    {
        public Fruit Create()
        {
            return new Pineapple();   
        }
    }

    class PineappleFarm : Farm 
    {
        public Fruit Create()
        {
            return new Apple();
        }
    }

    interface Fruit { }

    class Apple : Fruit { }
    class Pineapple : Fruit { }


    /// <summary>
    /// Example
    /// </summary>
    class Main
    {
        void ActualSituation()
        {
            // 농장(Farm)을 상속받은 자식 농장에서 무엇을 만들어 낼지는 자식만이 알수있다!
            Farm farm = new AppleFarm();
            Fruit fruit = farm.Create();
        }
    }
    #endregion


}
