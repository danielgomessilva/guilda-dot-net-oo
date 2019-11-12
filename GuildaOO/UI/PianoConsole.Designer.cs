using System;
using GuildaOO.UI.Components;

namespace GuildaOO.UI
{
    public partial class PianoConsole
    {
        protected override void Initialize()
        {
            var component = new CursorComponent()
                                .Subscribe(PrintYellow)
                                .Subscribe(Beep);

            AddComponent(component);
        }

        
    }
}
