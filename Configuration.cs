using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.自定义指令
{
    public class Configuration : IRocketPluginConfiguration
    {
        public List<Command> CustomCommand;
        public void LoadDefaults()
        {
            CustomCommand = new List<Command>()
            {
                new Command("admin","h"),
                new Command("god","g"),
                new Command("teleport","t"),
            };
        }
    }
}
