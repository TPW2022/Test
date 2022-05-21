using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightController
{
     static public class IDBG_ResponseData
    {
       
       static readonly public  Dictionary<string, string> W11 = new Dictionary<string, string>()
        {
            ["W11ACK0"] = "OK",
            ["W11NAK0"] = "Some data are incorrect.",
            ["W11NAK1"] = "Some CH No. is incorrect.",
            ["W11NAK3"] = "Control type of the body is not set in external control mode/LAN communication type.",
            ["WR00NAK"] = "Other errors (such as illegal header, command No., etc.)",
        };
        static readonly public Dictionary<string, string> All = new Dictionary<string, string>()
        {
            ["ACK0"] = "OK",
            ["NAK0"] = "Some data are incorrect.",
            ["NAK3"] = "Control type of the body is not set in external control mode/LAN communication type.",
            ["0NAK"] = "Other errors (such as illegal header, command No., etc.)",
        };

    }

}
