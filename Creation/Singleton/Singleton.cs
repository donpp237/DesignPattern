namespace DesignPattern.Creation.Singleton
{
    /* [Singleton]
     * 
     * 1. 전역에 객체를 하나만 만들고 싶을때 사용.
     * 2. 전역에서 객체로 접근하고 싶을때 사용.
     * 3. 객체에 저장된 값을 어디서든 동일하게 사용하고 싶을때 사용.
     * 4. 주로 관리 관련 객체(Manager)에서 활용.
     * 
     */

    #region Define

    /// <summary>
    /// Generic Singleton
    /// </summary>
    /// <typeparam name="T"> Class Type </typeparam>
    class Singleton<T> where T : class, new()
    {
        public static T Instance
        {
            get
            {
                if (m_instance == null)
                    m_instance = new T();

                return m_instance;
            }
        }
        private static T m_instance;
    }

    #endregion

    #region Using
    
    /// <summary>
    /// How to use Singleton?
    /// </summary>
    class UIManager : Singleton<UIManager> { }

    /// <summary>
    /// Example
    /// </summary>
    class Main
    {
        void ActualSituation()
        {
            // UI를 관리하는 객체를 호출해서 사용
            UIManager uiManager = UIManager.Instance;
        }
    }

    #endregion
}
