using System;
using _15_Facade;

namespace Facade.PageMaker
{
    public class Database
    {
        private Database() { }

        public static string FindUserMailaddress(string userName)
        {
            return MailData.ResourceManager.GetString(userName);
        }
    }
}
