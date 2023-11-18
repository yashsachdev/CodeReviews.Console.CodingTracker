using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yashsachdev.CodingTracker.Domain.Model;

namespace yashsachdev.CodingTracker.Domain.Interface
{
    internal interface ISessionRepository
    {
        CodingSession GetCodingSession(int codingsessionId);
        List<CodingSession> GetAllCodingSessions();
        CodingSession AddCodingSession(CodingSession codingSession);    
        CodingSession UpdateCodingSession(CodingSession codingSession); 
        void DeleteCodingSession(int codingsessionId);  
    }
}
