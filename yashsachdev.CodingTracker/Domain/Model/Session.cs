using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yashsachdev.CodingTracker.Domain.Model
{
    internal class Session
    {
        public int codingsessionId { get; set; }
        public int sessionId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public TimeSpan Duration { get { return endTime - startTime; } }
        public User user { get; set; }
        public int userId { get; set; }
    }
}
}
