namespace DesignPattern.Structure.Adapter
{
    /* [Adapter]
     * 
     * 1. 내부 코드 수정이 어려운 라이브러리를 원하는 형태, 기능으로 변경하고 싶을때 사용.
     * 2. 라이브러리를 멤버로 갖는 경우 객체 어댑터, 상속을 받는 경우 클래스 어댑터라 지칭.
     * 3. Wrapper라고도 칭함.
     * 
     */

    #region Define
    #endregion

    #region Using

    /// <summary>
    /// How to use Adaptor?
    /// </summary>
    interface Usb 
    {
        string Using();
    }

    /// <summary>
    /// Object Adapter
    /// </summary>
    class UsbAToCTpyeChanger_objectAdapter : Usb
    {
        USBAType m_adaptee;

        public UsbAToCTpyeChanger_objectAdapter(USBAType adaptee) 
        {
            m_adaptee = adaptee;
        }

        public string Using()
        {
            return $"Converting Complete! [ {m_adaptee.Using()} -> C Type USB";
        }
    }

    /// <summary>
    /// Class Adapter
    /// </summary>
    class UsbAToCTpyeChanger_classAdapter : USBAType , Usb
    {
        public string Using()
        {
            return $"Converting Complete! [ {base.Using()} -> C Type USB";
        }
    }

    /// <summary>
    /// Legacy Adaptee
    /// </summary>
    class USBAType 
    {
        public string Using() { return "A Type USB"; }
    }

    /// <summary>
    /// Example
    /// </summary>
    class Main
    {
        void ActualSituation()
        {
            // 객체 어댑터
            Usb usb = new UsbAToCTpyeChanger_objectAdapter(new USBAType());
            usb.Using();

            // 클래스 어댑터
            usb = new UsbAToCTpyeChanger_classAdapter();
            usb.Using();
        }
    }

    #endregion
}
