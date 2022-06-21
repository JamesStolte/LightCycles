using LightCycles.Game.Services;
namespace LightCycles.Game.Action;
{
    public class ChangeDirectionAction : Action
    {
        private KeyboardService keyboardService;
        public ChangeDirectionAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        private int rlvelocity = 0;
        private int velocity = 0;
        public void Execute()
        {
            if (keyboardService.IsKeyDown("a"))
            {
                rlvelocity = -5;
            }
            if (keyboardService.IsKeyDown("d"))
            {
                rlvelocity = 5;
            }
            if (keyboardService.IsKeyDown("w"))
            {
                velocity = 5;
            }
            if (keyboardService.IsKeyDown("s"))
            {
                velocity = -5;
            }
        }
    }
}