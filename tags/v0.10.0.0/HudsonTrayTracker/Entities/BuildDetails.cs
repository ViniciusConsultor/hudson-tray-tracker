using System;
using System.Collections.Generic;
using System.Text;
using Iesi.Collections.Generic;

namespace Hudson.TrayTracker.Entities
{
    public class BuildDetails
    {
        public int Number { get; set; }
        public string Url { get; set; }
        public DateTime Time { get; set; }
        public ISet<string> Users { get; set; }
    }
}
