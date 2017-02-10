
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;


namespace qaApplication
{
    public class Program
    {
        const string CARJOJO_URL = "https://fe.carjojo.com";

        public static void Main(string[] args)
        {
            // download and unzip driver in project folder http://chromedriver.storage.googleapis.com/index.html?path=2.27/
            var driver = new ChromeDriver(".");
            try
            {
                driver.Navigate().GoToUrl(CARJOJO_URL);
                driver.FindElementByClassName("brand").Click();
                Task.Delay(1000).Wait();
                driver.FindElementByClassName("model").Click();
                // Task.Delay(2000).Wait();
                // driver.FindElementByXPath("//*button[@class='button expand carjojo-button strange-limey-yellow']").Click();
                // Task.Delay(1000).Wait();
                // driver.FindElementByXPath("//*[contains(text(), 'SHOW VEHICLES')]").Click();
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
                System.Console.WriteLine("Closing browser in 3 sec ...");
            }
            finally
            {
                // Close the browser after 3 sec
                Task.Delay(3000).Wait();
                driver.Quit();
            }           
        }
    }
}
