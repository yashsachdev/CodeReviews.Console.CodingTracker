using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using yashsachdev.CodingTracker.Domain.Model;

namespace yashsachdev.CodingTracker.Domain.Interface
{
    internal interface ISessionRepo
    {
        Session GetSession(int sessionId);
        List<Session> GetAllSessions();
        Session AddSession(Session session);
        Session UpdateSession (Session session);    
        void DeleteSession(int sessionId);

    }
}
 