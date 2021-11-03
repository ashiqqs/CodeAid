using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPattern.Prototype
{
    public class MailInvitation:IClonable<MailInvitation>
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<byte[]> Attachements { get; set; }

        public MailInvitation Clone(MailInvitation invitation)
        {
            return (MailInvitation)invitation.MemberwiseClone();
        }
    }
}
