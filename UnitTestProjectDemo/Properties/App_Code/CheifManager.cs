using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace William
{
    /// <summary>
    /// Summary description for CheifManager
    /// </summary>
    public class ChiefManger : User
    {
        public string Password
        {
            get;
            set;
        }

        public Branch Branch
        {
            get;
            set;
        }


    }

}