using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ng2GetDataTest.Models.Model
{
    public class TestModel
    {
        public int ID { get; set; }
        public string ProcessID { get; set; }
        public Nullable<System.DateTime> aCreateTime { get; set; }
        public Nullable<System.DateTime> aModifyTime { get; set; }
        public string Applicant { get; set; }
        public string Department { get; set; }
        public double InvoiceValue { get; set; }
        public double PayMoney { get; set; }
        public string PayModel { get; set; }
        public string PayWho { get; set; }
        public string BankAccount { get; set; }
        public string ApplyStatus { get; set; }
        public string PayType { get; set; }

        public string DomainAccount { get; set; }
        public string UserTitleImg { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public Nullable<System.DateTime> bCreateTime { get; set; }
        public Nullable<System.DateTime> bModifyTime { get; set; }

        //public string PrcID { get; set; }
        //public string name { get; set; }
        //public string sex { get; set; }
        //public string id { get; set; }
        //public string desc { get; set; }
        //public bool completed { get; set; }
        //public string ProcessID { get; set; }
        //public string ProcessName { get; set; }
    }
}