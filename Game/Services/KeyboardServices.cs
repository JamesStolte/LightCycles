using System;
using Raylib_cs;

using Casting;


namespace Services
{


    public class KeyboardService
    {

        private Dictionary<string, KeyboardKey> keys = new Dictionary<string, KeyboardKey> 
            = new Dictionary<string, KeyboardKey>();
        


        public KeyboardService()
        {
            keys["w"] = KeyboardKey.KEY_W;
            keys["a"] = KeyboardKey.KEY_A;
            keys["s"] = KeyboardKey.KEY_S;
            keys["d"] = KeyboardKey.KEY_D;
            keys["i"] = KeyboardKey.KEY_I;
            keys["j"] = KeyboardKey.KEY_J;
            keys["k"] = KeyboardKey.KEY_K;
            keys["l"] = KeyboardKey.KEY_L;

        }

    // Check to see if the key is down
        public bool IsKeyDown(string key)
        {
            KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyDown(raylibKey);
        }

        /// <summary>
        /// Checks if the given key is currently up.
        /// </summary>
        /// <param name="key">The given key (w, a, s, d, i, j, k, or l)</param>
        /// <returns>True if the given key is up; false if otherwise.</returns>
        public bool IsKeyUp(string key)
        {
            KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyUp(raylibKey);
        }
    }
}