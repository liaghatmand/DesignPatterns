namespace ChainOfResponsibility.Handlers
{
    public abstract class Handler
    {
        protected Handler _nextHandler;

        public void SetNext(Handler nextHandler)
        {
            _nextHandler = nextHandler;
        }

    }
}
