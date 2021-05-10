using System;
using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;

namespace Gamemode
{
    public class GameMode : BaseMode
    {
        #region Overrides of BaseMode
		
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine(" pomocniczy.lc-rp.pl");
            Console.WriteLine("----------------------------------\n");

            // TODO: Put logic to initialize your game mode here
        }
     

        #endregion
    }
}