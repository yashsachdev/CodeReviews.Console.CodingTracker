
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yashsachdev.CodingTracker.Domain.Model
{
    internal class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public List<Session> sessions { get; set; }
    }
}
