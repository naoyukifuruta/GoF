using System;
using System.IO;
using System.Text;

namespace Facade.PageMaker
{
    public class PageMaker
    {
        private PageMaker() { }

        public static void MakeWelcomePage(string userName, string fileName)
        {
            string mailAddr = Database.FindUserMailaddress(userName);

            using (HtmlWriter writer = new HtmlWriter(new StreamWriter(fileName, false, Encoding.Unicode)))
            {
                writer.WriteTitle("Welcome to" + userName + "'s Page!");
                writer.WriteParagraph(userName + "のページへようこそ");
                writer.WriteParagraph("メールまってますね。");
                writer.WriteMailTo(mailAddr, userName);
                writer.Close();
            }

            Console.WriteLine(fileName + @" is created for " + mailAddr + @" (" + userName + @")");
            Console.ReadKey();
        }
    }
}
