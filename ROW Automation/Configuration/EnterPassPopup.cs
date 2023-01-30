using OpenQA.Selenium;
using ROWriter;

namespace ROWriter.Configuration
{
    class EnterPassWin : Core
    {
        public void EnterPasswordWin()
        {

            var EnterPass = driver.FindElement(By.Name("Enter Password"));
            EnterPass.Click();
            var Ok_Btn = EnterPass.FindElement(By.Name("Ok"));
            Ok_Btn.Click();
        }
    }
}
