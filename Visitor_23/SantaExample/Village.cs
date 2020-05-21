using System.Collections;

namespace Visitor_23.SantaExample
{
    public class Village
    {
        // Дома в деревне
        ArrayList elements = new ArrayList();

        public void Add(Element element)
        {
            elements.Add(element);
        }

        public void Remove(Element element)
        {
            elements.Remove(element);
        }

        /// <summary>
        /// Приглашаем деда-мороза в деревню
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
            {
                // стучится в каждый дом в деревне
                element.Accept(visitor);
            }
        }
    }
}