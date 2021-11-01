using System;

namespace DesignPattern.Singleton
{
    public sealed class ApplicationState
    {
        private static ApplicationState _instance { get; set; }
        public string LoggedUser { get; set; }
        public string Role { get; set; }

        private ApplicationState(){}

        private static object locker = new object();

        public static ApplicationState GetInstance()
        {
            lock (locker) //ensuring other thread could not create instance
            {
                if(_instance is null)
                {
                    _instance = new ApplicationState();
                }
                return _instance;
            }
        }
    }
}
