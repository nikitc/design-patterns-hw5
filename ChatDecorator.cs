namespace DesignPatternsHW5
{
    public class ChatDecorator : Chat
    {
        private readonly Chat _chat;

        public ChatDecorator(Chat chat)
        {
            _chat = chat;
        }

        public override void SendMessage(Message message)
        {
            ShifrSendMessage(message);
        }

        public override Message GetMessage()
        {
            return UnShifrGetMessage(_chat.GetMessage());
        }

        protected virtual void ShifrSendMessage(Message message)
        {
            _chat.SendMessage(message);
        }

        protected virtual Message UnShifrGetMessage(Message message)
        {
            return _chat.GetMessage();
        }
    }
}
