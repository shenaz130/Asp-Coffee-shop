using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace William
{
    /// <summary>
    /// Summary description for MorningPackage
    /// </summary>
    public class MorningPackage : Packages
    {
        public object CheeseSandwich
        {
            get;
            set;
        }

        public object ChickenBurger
        {
            get;
            set;
        }

        public object VegBurger
        {
            get;
            set;
        }

        public object GreenSalad
        {
            get;
            set;
        }

        public object StrawberrySundae
        {
            get;
            set;
        }

        public object CaramelLatte
        {
            get;
            set;
        }
        public void GetMorningData()
        {

            MorningPackage mrg = new MorningPackage();
            mrg = null;




        }


    }
}