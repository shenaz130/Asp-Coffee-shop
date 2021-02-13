using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace William
{
    /// <summary>
    /// Summary description for Sales
    /// </summary>
    public class Sales
    {
        public int SalesId
        {
            get;
            set;
        }

        public int CustomerId
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public string CustomerName
        {
            get;
            set;
        }

        public int UnitPrice
        {
            get;
            set;
        }

        public int ProductId
        {
            get;
            set;
        }

        public string SalesDate
        {
            get;
            set;
        }

        public int TotalAmount
        {
            get;
            set;
        }

        public string SalesTime
        {
            get;
            set;
        }

        public Product Product
        {
            get;
            set;
        }

        public void AddSales()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSales()
        {
            throw new System.NotImplementedException();
        }

        public void ViewSales()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteSales()
        {
            throw new System.NotImplementedException();
        }

        public void SearchSales()
        {
            throw new System.NotImplementedException();
        }


        public System.Data.DataTable GetSalesData()
        {
            throw new NotImplementedException();
        }
    }

}