using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week_6
{
    public class Song
    {
        public string Title { get; set; }
        public int DurationInSeconds { get; set; }

        public override string ToString() => $"{Title} ({DurationInSeconds}s)";
    }
}
