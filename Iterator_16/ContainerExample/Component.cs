using System;
using System.ComponentModel;

namespace Iterator_16.ContainerExample
{
    public class Component: IComponent
    {
        public void Dispose()
        {
            if (Disposed != null)
            {
                Disposed.Invoke(this, EventArgs.Empty);
            }
        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;
    }
}