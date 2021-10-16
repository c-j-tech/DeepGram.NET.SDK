using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ConsoleApplication
{
    public class AppSettings
    {
        public DeepGramSettings DeepGramSettings { get; set; }

        public ConsoleSettings ConsoleSettings { get; set; }
    }

    public class ConsoleSettings
    {
        public string Title { get; set; }
    }
}
