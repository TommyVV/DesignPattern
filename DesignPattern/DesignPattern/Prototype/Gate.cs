using DesignPattern.Prototype.Model;
using System;

namespace DesignPattern.Prototype
{
    public class Gate
    {
        public static void SendEmail(Email email)
        {
            Console.WriteLine(string.Format("邮件已发送至：『{0}』", email.Receiver));
        }
    }
}
