using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Prototype
{
    public class MailSender
    {
        
        public List<MailInvitation> GetInvitations(IClonable<MailInvitation> invitation, List<string> friends)
        {
            List<MailInvitation> invitations = new List<MailInvitation>();
            var clonedInvite = (MailInvitation)(invitation);
            invitations.Add(clonedInvite);

            foreach (var friend in friends.Select((name, index) => (name, index)))
            {
                //Making prototype of invitation
                invitations.Add(invitation.Clone(clonedInvite));
                invitations[friend.index + 1].To = friend.name;
            }

            return invitations;
        }
    }
}
