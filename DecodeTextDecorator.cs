namespace DesignPatternsHW5
{
    public class DecodeTextDecorator : ChatDecorator
    {
        public DecodeTextDecorator(Chat chat) : base(chat)
        {

        }

        protected override void ShifrSendMessage(Message message)
        {
            message.Text = "<Shifr>" + message.Text + "</Shifr>";
            base.ShifrSendMessage(message);
        }

        protected override Message UnShifrGetMessage(Message message)
        {
            message.Text = message.Text.Substring(7, message.Text.Length - 8);
            return base.UnShifrGetMessage(message);
        }
    }
}
