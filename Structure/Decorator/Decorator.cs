using System;

namespace DesignPattern.Structure.Decorator
{
    /* [Decorator]
    * 
    * 1. 원본 객체(Base)를 다양하게 장식(Decorator)하는 방법.
    * 2. 장식한 순서는 변경이 불가능.
    * 
    */


    #region Define

    interface Base 
    {
        void Echo();
    }

    /// <summary>
    /// Decorator Target Class
    /// </summary>
    class Instance : Base 
    {
        public void Echo()
        {
            Console.WriteLine("Hello World");
        }
    }

    /// <summary>
    /// Decorator Base Interface
    /// </summary>
    abstract class Decorator : Base
    {
        protected Instance Instance { get; }
        
        public Decorator(Instance instance)
        {
            this.Instance = instance;
        }

        public virtual void Echo()
        {
            this.Instance.Echo();
        }
    }

    class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Instance instance) : base(instance) { }

        public override void Echo()
        {
            base.Echo();
            Console.WriteLine("Add Concrete");
        }
    }

    #endregion

    #region Using

    interface Domino 
    {
        void HereYouAre();
    }

    /// <summary>
    /// How to use Decorator Target Class?
    /// </summary>
    class Pizza : Domino
    {
        public void HereYouAre()
        {
            Console.WriteLine("피자 나왔습니다.");
        }
    }

    /// <summary>
    /// How to use Decorator Base Interface?
    /// </summary>
    abstract class Topping : Domino
    {
        private Domino m_pizza;
        
        public Topping(Domino pizza) 
        {
            m_pizza = pizza;
        }

        public virtual void HereYouAre()
        {
            m_pizza.HereYouAre();
        }
    }

    class Tomato : Topping
    {
        public Tomato(Domino pizza) : base(pizza) { }

        public override void HereYouAre()
        {
            Console.WriteLine("토마토 얹었음.");
            base.HereYouAre();
        }
    }

    /// <summary>
    /// Example
    /// </summary>
    class Main
    {
        void ActualSituation()
        {
            // 원본
            Domino origin = new Pizza();
            origin.HereYouAre();

            Domino originWithTomato = new Tomato(new Pizza());
            originWithTomato.HereYouAre();
        }
    }

    #endregion
}
