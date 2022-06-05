using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace Serial_Communicator
{
    class Helper
    {
        #region Parity region
        public static string ParityIdToString(Parity id)
        {
            if (id == Parity.None) return "None";
            if (id == Parity.Odd) return "Odd";
            if (id == Parity.Even) return "Even";
            if (id == Parity.Mark) return "Mark";
            if (id == Parity.Space) return "Space";
            throw new Exception("Id is out of bound");            
        }
        public static int ParityIdToInt(Parity id)
        {
            if (id == Parity.None) return 0;
            if (id == Parity.Odd) return 1;
            if (id == Parity.Even) return 2;
            if (id == Parity.Mark) return 3;
            if (id == Parity.Space) return 4;
            throw new Exception("Id is out of bound");
        }

        public static Parity ParityStringToId(string name)
        {
           if(name == "None") return Parity.None;
           if(name == "Odd") return Parity.Odd;
           if(name == "Even") return Parity.Even;
           if(name == "Mark") return Parity.Mark;
           if(name == "Space") return Parity.Space;
            throw new Exception("Name not found");
        }

        #endregion

        #region StopBits region
        public static string StopIdToString(StopBits id)
        {
            if (id == StopBits.None) return "None";
            if (id == StopBits.One) return "One";
            if (id == StopBits.Two) return "Two";
            if (id == StopBits.OnePointFive) return "1.5";
            throw new Exception("Id out of bound");
        }
        public static int StopIdToInt(StopBits id)
        {
            if (id == StopBits.None) return 0;
            if (id == StopBits.One) return 1;
            if (id == StopBits.Two) return 2;
            if (id == StopBits.OnePointFive) return 3;
            throw new Exception("Id out of bound");
        }

        public static StopBits StopStringToId(string name)
        {
            if (name == "None") return StopBits.None;
            if (name == "One") return StopBits.One;
            if (name == "Two") return StopBits.Two;
            if (name == "1.5") return StopBits.OnePointFive;

            throw new Exception("Name not found");
        }
        #endregion

        #region Flow control(Handshake)
        public static string HandIdToString(Handshake id)
        {
            if (id == Handshake.None) return "None";
            if (id == Handshake.XOnXOff) return "XON/XOFF";
            if (id == Handshake.RequestToSend) return "RTS";
            if (id == Handshake.RequestToSendXOnXOff) return "RTS & XON/XOFF (unavaliable)";
            throw new Exception("Id out of bound");
        }
        public static int HandIdToInt(Handshake id)
        {
            if (id == Handshake.None) return 0;
            if (id == Handshake.XOnXOff) return 1;
            if (id == Handshake.RequestToSend) return 2;
            if (id == Handshake.RequestToSendXOnXOff) return 3;
            throw new Exception("Id out of bound");
        }

        public static Handshake HandStringToId(string name)
        {
            if (name == "None") return Handshake.None;
            if (name == "XON/XOFF") return Handshake.XOnXOff;
            if (name == "RTS") return Handshake.RequestToSend;
            if (name == "RTS & XON/XOFF (unavaliable)") return Handshake.RequestToSendXOnXOff;

            throw new Exception("Name not found");
        }
        #endregion

        #region Terminator
        public static int TermStringToId(string listing)
        {
            if (listing == "None") return 0;
            if (listing == "CR (/r)") return 1;
            if (listing == "LF (/n)") return 2;
            if (listing == "CRLF (/r/n)") return 3;
            if (listing == "Own") return 4;
            throw new Exception("Not listed");
        }

        public static int TermToInt(string listing)
        {
            if (listing == "") return 0;
            if (listing == "\r") return 1;
            if (listing == "\n") return 2;
            if (listing == "\r\n") return 3;
            /*else*/ return 4;
        }

        public static string convertTerminators(string term)
        {
            return Regex.Escape(term);
        }

        #endregion
    }
}
