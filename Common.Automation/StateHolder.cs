using System;
using OpenQA.Selenium;

namespace Common.Automation
{
    public static class StateHolder
    {
        public static IWebDriver Driver;
        public static T CreateObject<T>()
        {
            var obj = (T)Activator.CreateInstance(typeof(T), Driver);
            return obj;
        }

        public static void Intitialize(IWebDriver driver)
        {
            if (Driver == null)
            {
                Driver = driver;
                return;
            }
            throw new Exception("Trying to initialize Driver more than once!");
        }
        public static void Utilize()
        {
            Driver = null;
        }
    }
}
