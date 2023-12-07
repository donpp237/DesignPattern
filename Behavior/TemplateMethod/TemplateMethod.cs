using System;

namespace DesignPattern.Behavior.TemplateMethod
{
    /* [Template Method]
    * 
    * 1. 자식 클래스에서 재사용 할 수 있는 함수 선언.
    * 2. 자식 클래스에서 함수를 오버라이딩 하여 재사용.
    * 
    */

    #region Define

    /// <summary>
    /// Template Method Interface
    /// </summary>
    interface TemplateMethod
    {
        string ShowMessage();
    }

    #endregion

    #region Using

    /// <summary>
    /// How to use Template Method?
    /// </summary>
    interface Country
    {
        string SayHello();
    }

    class Korea : Country
    {
        public string SayHello()
        {
            return "안녕";
        }
    }

    class USA : Country 
    {
        public string SayHello()
        {
            return "HI";
        }
    }

    /// <summary>
    /// Example
    /// </summary>
    class Main
    {
        void ActualSituation()
        {
            // 국가별 인사를 출력
            Country country = new Korea();
            Console.WriteLine(country.SayHello());

            country = new USA();
            Console.WriteLine(country.SayHello());
        }
    }

    #endregion

}
