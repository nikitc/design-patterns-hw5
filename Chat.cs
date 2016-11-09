namespace DesignPatternsHW5
{
    public abstract class Chat
    {
        public abstract void SendMessage(Message message);

        public abstract Message GetMessage();
    }
}
