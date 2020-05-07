namespace Decorator_9
{
    public class Decorator: Component
    {
        /// <summary>
        /// Если это пропеллер, то он будет ссылаться на рубашку. А рубашка уже будет ссылаться на
        /// Карлсона.
        /// </summary>
        public Component Component { protected get; set; }
        
        public override void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }
    }
}