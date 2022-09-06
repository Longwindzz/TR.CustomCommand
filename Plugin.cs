using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.自定义指令
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Instance;
        bool 加载 = false;

        protected override void Load()
        {
            Instance = this;
            Rocket.Core.Logging.Logger.Log("Welcome to use TR.CustomCommand！——By TR.Plugin");
            Rocket.Core.Logging.Logger.Log("———————————");
            Rocket.Core.Logging.Logger.Log("————Author—————");
            Rocket.Core.Logging.Logger.Log("————长风—————");
            Rocket.Core.Logging.Logger.Log("——TCD.ROCKETMOD———");
            Rocket.Core.Logging.Logger.Log("Verson 1.1.0 Load Succused！");
            U.Events.OnPlayerConnected += 玩家进服;

        }

        private void 玩家进服(UnturnedPlayer player)
        {
            if(加载==false)
            {
                加载 = true;
                foreach (Command 指令 in Configuration.Instance.CustomCommand)
                {
                    
                    IRocketCommand command = R.Commands.GetCommand(指令.OldCommand);
                    if (command != null&&指令.OldCommand!=null)
                    {
                        R.Commands.Register(command, 指令.NewCommand);
                    }
                }
                Rocket.Core.Logging.Logger.Log("All CustomCommand Load！");
            }
        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= 玩家进服;
        }
    }
}
