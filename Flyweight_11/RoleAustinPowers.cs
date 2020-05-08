namespace Flyweight_11
{
    /// <summary>
    /// Это всего лишь роль. Она не может говорить. Это просто костюм.
    /// Чтобы он сказал свою речь - надо его натянуть на Майка Майерса.
    /// У Майка есть вся функциональность для того, чтоб произнести речь.
    /// </summary>
    public class RoleAustinPowers: Flyweight
    {
        private readonly Flyweight _flyweight;

        public RoleAustinPowers(Flyweight flyweight)
        {
            _flyweight = flyweight;
        }
        
        public override void Greeting(string speech)
        {
            _flyweight.Greeting(speech);    
        }
    }
}