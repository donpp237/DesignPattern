namespace DesignPattern.Creation.Builder
{
    /* [Builder]
     * 
     * 1. 순차적으로 처리해야하는 행동(Function)이 존재하는 경우 사용.
     * 2. 순서를 정의 할 수 있는 관리자(Director) 사용하면 좋음.
     * 
     */

    #region Define

    /// <summary>
    /// Builder Interface
    /// </summary>
    interface Builder
    {
        void PreProcess();
        void Build();
        void PostProcess();
    }

    #endregion

    #region Using

    /// <summary>
    /// How to use Builder?
    /// </summary>
    interface Chair
    {
        void CreateLeg();
        void CreateBack();
    }

    class IKEAChair : Chair
    {
        public void CreateBack(){}

        public void CreateLeg(){}
    }

    /// <summary>
    /// How to use Director?
    /// </summary>
    class Carpenter
    {
        public Chair MakeIkeaChair()
        {
            IKEAChair chair = new IKEAChair();
            chair.CreateLeg();
            chair.CreateBack();

            return chair;
        }
    }

    /// <summary>
    /// Example
    /// </summary>
    class Main
    {
        void ActualSituation()
        {
            // 목수가 IKEA 의자를 자신만의 방법과 순서로 제작
            Carpenter carpenter = new Carpenter();
            carpenter.MakeIkeaChair();
        }
    }

    #endregion


}
