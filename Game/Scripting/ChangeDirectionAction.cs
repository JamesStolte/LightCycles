
using Services;
namespace LightCycles.Game;
{
    public class ChangeDirectionAction : Actor
    {
        private KeyboardServices keyboardServices;
        public ChangeDirectionAction(KeyboardServices keyboardServices)
        {
            this.keyboardServices = keyboardServices;
        }

        private int rlvelocity = 0;
        private int velocity = 0;
        public void Execute()
        {
            if (keyboardServices.IsKeyDown("a"))
            {
                rlvelocity = -5;
            }
            if (keyboardServices.IsKeyDown("d"))
            {
                rlvelocity = 5;
            }
            if (keyboardServices.IsKeyDown("w"))
            {
                velocity = 5;
            }
            if (keyboardServices.IsKeyDown("s"))
            {
                velocity = -5;
            }
        }
    }
}