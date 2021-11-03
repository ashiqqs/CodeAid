using DesignPattern.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace DesignPattern.Console
{
    public class TestPrototypePattern
    {
        private static List<string> _friends = new List<string> { 
            "reza@nybsys.com", "masud@nybsys.com", "kayhan@nybsys.com", "tareq@nybsys.com" };
        public static void Test()
        {
            MailInvitation invitation = new MailInvitation();
            invitation.From = "ashiq.mail.net@gmail.com";
            invitation.To = "ashiq@nybsys.com";
            invitation.Subject = "Birthday party invitation.";
            invitation.Body = "mail body";

            var listInvites = new MailSender().GetInvitations(invitation, _friends);

            foreach(var inv in listInvites.Select((Mail, Serial)=>(Mail, Serial)))
            {
                WriteLine($"{inv.Serial + 1}. Mail sent to {inv.Mail.To}, Subject: {inv.Mail.Subject}");
            }
        }
    }
}
