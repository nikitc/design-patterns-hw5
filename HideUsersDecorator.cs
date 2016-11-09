using System.Collections.Generic;

namespace DesignPatternsHW5
{
    public class HideUsersDecorator : ChatDecorator
    {
        public Dictionary<string, string> LoginToShifr = new Dictionary<string, string>()
        {
            {"Evgeniy","123123" },
            {"Andrey","29901" }
        };


        public Dictionary<string, string> ShifrToLogin = new Dictionary<string, string>()
        {
            {"123123","Evgeniy" },
            {"29901","Andrey" }
        };

        protected HideUsersDecorator(Chat chat) : base(chat)
        {
        }

        protected override void ShifrSendMessage(Message message)
        {
            message.Author = LoginToShifr[message.Author];
            message.Addressee = LoginToShifr[message.Addressee];
            base.ShifrSendMessage(message);
        }

        protected override Message UnShifrGetMessage(Message message)
        {
            message.Author = ShifrToLogin[message.Author];
            message.Addressee = ShifrToLogin[message.Addressee];
            return base.UnShifrGetMessage(message);
        }
    }
}
