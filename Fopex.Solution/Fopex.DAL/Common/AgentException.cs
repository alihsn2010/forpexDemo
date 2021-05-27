using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fopex.DAL.Common
{
    public class AgentException  : Exception
    {
        private int errorCode;

        public AgentException(int p_ErrorCode, String p_message)
            : base(p_message)
        {
            errorCode = p_ErrorCode;
        }

        public int ErrorCode 
        {
            get{return errorCode;}
            set {errorCode = value;}
        }
    }
}
