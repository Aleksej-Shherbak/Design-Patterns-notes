namespace Proxy_12
{
    public class Surrogate: IHuman
    {
        private readonly IHuman _operator;

        /// <summary>
        /// Все передает своему оператору
        /// </summary>
        /// <param name="operator"></param>
        public Surrogate(IHuman @operator)
        {
            _operator = @operator;
        }

        public void Request()
        {
            _operator.Request();
        }
    }
}