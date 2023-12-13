using System;

namespace DesignPattern.Structure.Bridge
{
    /* [Bridge]
    * 
    * 1. 객체를 표현하는 클래스와 
    *    객체의 기능을 표현하는 클래스 모두 종류를 늘리고 싶을때 사용.
    * 
    */

    #region Define

    /// <summary>
    /// Bridge Main Interface
    /// </summary>
    interface Instance
    {
        Function Function { get; }
    }

    /// <summary>
    /// Bridge Sub Interface
    /// </summary>
    interface Function {}

    #endregion

    #region Using

    /// <summary>
    /// How to use Bridge Main Interface?
    /// </summary>
    interface Fruit
    {
        string Name { get; }
        Color Color { get; set; }
    }

    class Apple : Fruit
    {
        public string Name { get; } = "Apple";
        public Color Color { get; set; }
    }

    class Banana : Fruit
    {
        public string Name { get; } = "Banana";
        public Color Color { get; set; }
    }

    /// <summary>
    /// How to use Bridge Sub Interface?
    /// </summary>
    interface Color
    {
        string Name { get; }
    }

    class Red : Color
    {
        public string Name => "Red";
    }

    class Green : Color
    {
        public string Name => "Green";
    }

    /// <summary>
    /// Example
    /// </summary>
    class Main
    {
        void ActualSituation()
        {
            // 사과 실체화
            Fruit fruit = new Apple();
            Console.WriteLine($"Q. What is Fruit?, A. {fruit.Name}");

            // 사과의 색상 할당
            fruit.Color = new Red();
            Console.WriteLine($"Q. What is Fruit Color ?, A. {fruit.Color.Name}");


            // 바나나 실체화
            fruit = new Banana();
            Console.WriteLine($"Q. What is Fruit?, A. {fruit.Name}");

            // 바나나의 색상 할당
            fruit.Color = new Green();
            Console.WriteLine($"Q. What is Fruit Color ?, A. {fruit.Color.Name}");
        }
    }

    #endregion
}
