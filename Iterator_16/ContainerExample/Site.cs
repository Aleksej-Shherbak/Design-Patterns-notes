using System;
using System.ComponentModel;

namespace Iterator_16.ContainerExample
{
    public class Site: ISite
    {
        public object GetService(Type serviceType)
        {
            // сервисы не используются в данном примере
            throw new NotImplementedException();
        }

        public IComponent Component { get; set; }
        public IContainer Container { get; set;}
        public bool DesignMode => false;
        public string Name { get; set; }
    }
}