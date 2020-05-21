namespace Visitor_23.SantaExample
{
    public abstract class Element
    {
        /// <summary>
        /// Метод согласия. Дом реализует метод, как бы соглашаясь на то, чтоб дед-мороз зашел. 
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Accept(Visitor visitor);
    }
}