using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace CompetitionTasks.Pages
{
    public class ScreenShot
    {
        public static void takeScreenshot(IWebDriver driver)
        {

            //option 1

            String ScreenshotFileName = Directory.GetParent(@"C:\Users\anoop\Desktop\CompetitionTasks\CompetitionTasks\CompetitionTasks\ScreenShot").FullName
            + Path.DirectorySeparatorChar
             + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".png";
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(ScreenshotFileName, ScreenshotImageFormat.Png);


            //option 1
            // ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\Users\anoop\Desktop\CompetitionTrial\CompetitionTrial\Screenshot\"
            // + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Jpeg);


            //option 3 from sol file which is having some errors
            // var folderLocation = ("Path to save Screenshots");
            // if (!System.IO.Directory.Exists(@"C:\Users\anoop\Desktop\CompetitionTrial\CompetitionTrial\Screenshot\"));
            //{
            //   System.IO.Directory.CreateDirectory(@"C:\Users\anoop\Desktop\CompetitionTrial\CompetitionTrial\Screenshot\");
            // }
            //var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            // var fileName = new StringBuilder(@"C:\Users\anoop\Desktop\CompetitionTrial\CompetitionTrial\Screenshot\");
            // fileName.Append(ScreenShotFileName);
            // fileName.Append(DateTime.Now.ToString(“dd-MM-yyyy"));
            //fileName.Append(DateTime.Now.ToString(“dd-mm-yyyym_ss”));
            //fileName.Append(“.png”);
            //screenShot.SaveAsFile(fileName.ToString(), System.Drawing.Imaging.ImageFormat.Png);
            // return fileName.ToString();
            //option 3


        }
    }



}





