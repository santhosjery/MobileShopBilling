using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopBilling
{
    public class MsgBoxMessages
    {
        public string show( string title,string msg)
        {
            return MyMessageBox.ShowBox(title,msg);
        }
        public void singlemsgtext(string msg)
        {
             MyMessageBox.singlemsgtext(msg);
        }
        public string msg(string title,string message)
        {
            return MyMessageBox.ShowBox(title, message);
        }
    }
}