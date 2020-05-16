using System.Collections.Generic;
using System.ComponentModel;

namespace Iterator_16.ContainerExample
{
    public class Container: IContainer
    {
        List<IComponent> list = new List<IComponent>();
        
        public ComponentCollection Components => new ComponentCollection(list.ToArray());
        
        public void Dispose()
        {
            list.ForEach(x => x.Dispose());
            list.Clear();
        }

        public void Add(IComponent component)
        {
            list.Add(component);
        }

        public void Add(IComponent component, string name)
        {
            component.Site = new Site
            {
                Component = component,
                Container = this,
                Name = name
            };
            
            list.Add(component);
        }

        public void Remove(IComponent component)
        {
            list.Remove(component);
        }

    }
}