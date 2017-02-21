using ng2GetDataTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ng2GetDataTest.Controllers
{
    public class GetDataTestController : ApiController
    {
        private DbTestEntities2 db = new DbTestEntities2();

        // GET api/GetDataTest
        public IEnumerable<Models.Model.TestModel> GetDataTest()
        {


            List<Models.Model.TestModel> rec = (from a in db.UserInfo
                                                join b in db.ApplyInfo on a.ProcessID equals b.ProcessID

                                                select new Models.Model.TestModel
                                                {
                                                    ID = a.ID,
                                                    ProcessID = a.ProcessID,
                                                    DomainAccount = a.DomainAccount,
                                                    UserTitleImg = a.UserTitleImg,
                                                    UserName = a.UserName,
                                                    UserPassword = a.UserPassword,
                                                    aCreateTime = a.CreateTime,
                                                    aModifyTime = a.ModifyTime,

                                                    bCreateTime = b.CreateTime,
                                                    bModifyTime = b.ModifyTime,
                                                    Applicant = b.Applicant,
                                                    Department = b.Department,
                                                    InvoiceValue = b.InvoiceValue,
                                                    PayMoney = b.PayMoney,
                                                    PayModel = b.PayModel,
                                                    PayWho = b.PayWho,
                                                    BankAccount = b.BankAccount,
                                                    ApplyStatus = b.ApplyStatus,
                                                    PayType = b.PayType
                                                }).ToList();
           
            return rec;
        }
    }
}
