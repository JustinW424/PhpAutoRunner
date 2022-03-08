using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpRunner.utility
{
    public class ScriptInfo
    {
        public ScriptInfo()
        {
            this.url = "";
            this.interval = 30;
        }
        public string url { get; set; }
        public int interval { get; set; }
    }
}
