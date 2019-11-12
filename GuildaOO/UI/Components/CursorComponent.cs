using System;

namespace GuildaOO.UI.Components
{
    public enum Direction
    {
        LeftArrow =100,
        UpArrow =200,
        RightArrow =300,
        DownArrow=400,
        Invalid=50
    }
    class CursorComponent : IComponent
    {
        
        public delegate void EventHandle(Direction direction);
        private event EventHandle _component;

        public CursorComponent Subscribe(EventHandle e)
        {
            _component += e;
            return this;
        }
        public void Run()
        {
            while(true)
            {
                var key = Console.ReadKey();
                var direction = Direction.Invalid;

                try
                {
                    direction = Enum.Parse<Direction>(key.Key.ToString());
                }
                catch
                {
                    direction = Direction.Invalid;
                }
                finally
                {
                    _component.Invoke(direction);
                }
            }
        }

    }
}
