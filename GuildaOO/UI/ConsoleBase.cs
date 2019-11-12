using GuildaOO.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildaOO.UI
{
    public abstract class ConsoleBase
    {
        private IComponent _component;
        protected void AddComponent(IComponent component)
            => _component = component;
        public void Run()
        {
            Initialize();
            _component.Run();
        }
        protected abstract void Initialize();
    }
}
