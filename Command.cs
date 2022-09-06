using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TR.自定义指令
{
    public  class Command
    {
        [XmlAttribute]
        public  string OldCommand { get; set; }
        [XmlAttribute]
        public string NewCommand { get;set; }

        public Command(string OldCommand, string NewCommand)
        {
            this.OldCommand = OldCommand;
            this.NewCommand = NewCommand;
        }

        public Command() { }
    }
}
