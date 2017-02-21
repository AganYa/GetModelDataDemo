using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ng2GetDataTest.Models;
using System.Web.Mvc;

namespace ng2GetDataTest.Controllers
{
    public class GetDataController : ApiController
    {
        private DbTestEntities1 db = new DbTestEntities1();

        // GET api/GetData
        public IEnumerable<Models.Model.TestModel> GetTestTabs()
        {


           List<Models.Model.TestModel> rec = (from a in db.TestTab
                      join b in db.Info on a.id equals b.PrcID 
                      
                      select new Models.Model.TestModel
                               {
                                   //id = a.id,
                                   //desc = a.desc,
                                   //completed = a.completed,
                                   //ProcessID = a.ProcessID,
                                   //ProcessName = a.ProcessName,
                                   //PrcID = b.PrcID,
                                   //name = b.name,
                                   //sex = b.sex
                               }).ToList();
            //List<Models.TestTab> listCla = db.TestTab.Where(c => c.completed == true).ToList();
  
            return rec;
        }

        // GET api/GetData/5
        public TestTab GetTestTab(string id)
        {
            TestTab testtab = db.TestTab.Find(id);
            if (testtab == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return testtab;
        }

        // PUT api/GetData/5
        public HttpResponseMessage PutTestTab(string id, TestTab testtab)
        {
            if (ModelState.IsValid && id == testtab.id)
            {
                db.Entry(testtab).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/GetData
        public HttpResponseMessage PostTestTab(TestTab testtab)
        {
            if (ModelState.IsValid)
            {
                db.TestTab.Add(testtab);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, testtab);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = testtab.id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/GetData/5
        public HttpResponseMessage DeleteTestTab(string id)
        {
            TestTab testtab = db.TestTab.Find(id);
            if (testtab == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.TestTab.Remove(testtab);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, testtab);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}