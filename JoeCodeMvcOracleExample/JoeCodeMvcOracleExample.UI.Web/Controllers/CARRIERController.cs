using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JoeCodeMvcOracleExample.UI.Web.ResourceAccess.Contexts;
using JoeCodeMvcOracleExample.UI.Web.ResourceAccess.Entities;

namespace JoeCodeMvcOracleExample.UI.Web.Controllers
{
    public class CARRIERController : Controller
    {
        private Model1 db = new Model1();

        // GET: CARRIER
        public ActionResult Index()
        {
            return View(db.IRCS_ARR_FLT_CARRIER.ToList());
        }

        // GET: CARRIER/Details/5
        public ActionResult Details(string IRCS_FLT_CARRIER_CD ,string IRCS_FLT_CARRIER_STN)
        {
            if (IRCS_FLT_CARRIER_CD == null || IRCS_FLT_CARRIER_STN ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IRCS_ARR_FLT_CARRIER iRCS_ARR_FLT_CARRIER = db.IRCS_ARR_FLT_CARRIER.Find(IRCS_FLT_CARRIER_CD, IRCS_FLT_CARRIER_STN);
            if (iRCS_ARR_FLT_CARRIER == null)
            {
                return HttpNotFound();
            }
            return View(iRCS_ARR_FLT_CARRIER);
        }

        // GET: CARRIER/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CARRIER/Create
        // 若要免於大量指派 (overposting) 攻擊，請啟用您要繫結的特定屬性，
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IRCS_FLT_CARRIER_CD,IRCS_FLT_CARRIER_STN,IRCS_FLT_CARRIER_EN,IRCS_FLT_CARRIER_CN,IRCS_FLT_CARRIER_CREATE_ID,IRCS_FLT_CARRIER_CREATE_DT,IRCS_FLT_CARRIER_UPDATE_ID,IRCS_FLT_CARRIER_UPDATE_DT")] IRCS_ARR_FLT_CARRIER iRCS_ARR_FLT_CARRIER)
        {
            if (ModelState.IsValid)
            {
                db.IRCS_ARR_FLT_CARRIER.Add(iRCS_ARR_FLT_CARRIER);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iRCS_ARR_FLT_CARRIER);
        }

        // GET: CARRIER/Edit/5
        public ActionResult Edit(string IRCS_FLT_CARRIER_CD, string IRCS_FLT_CARRIER_STN)
        {
            if (IRCS_FLT_CARRIER_CD == null || IRCS_FLT_CARRIER_STN == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IRCS_ARR_FLT_CARRIER iRCS_ARR_FLT_CARRIER = db.IRCS_ARR_FLT_CARRIER.Find(IRCS_FLT_CARRIER_CD, IRCS_FLT_CARRIER_STN);
            if (iRCS_ARR_FLT_CARRIER == null)
            {
                return HttpNotFound();
            }
            return View(iRCS_ARR_FLT_CARRIER);
        }

        // POST: CARRIER/Edit/5
        // 若要免於大量指派 (overposting) 攻擊，請啟用您要繫結的特定屬性，
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IRCS_FLT_CARRIER_CD,IRCS_FLT_CARRIER_STN,IRCS_FLT_CARRIER_EN,IRCS_FLT_CARRIER_CN,IRCS_FLT_CARRIER_CREATE_ID,IRCS_FLT_CARRIER_CREATE_DT,IRCS_FLT_CARRIER_UPDATE_ID,IRCS_FLT_CARRIER_UPDATE_DT")] IRCS_ARR_FLT_CARRIER iRCS_ARR_FLT_CARRIER)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iRCS_ARR_FLT_CARRIER).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iRCS_ARR_FLT_CARRIER);
        }

        // GET: CARRIER/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IRCS_ARR_FLT_CARRIER iRCS_ARR_FLT_CARRIER = db.IRCS_ARR_FLT_CARRIER.Find(id);
            if (iRCS_ARR_FLT_CARRIER == null)
            {
                return HttpNotFound();
            }
            return View(iRCS_ARR_FLT_CARRIER);
        }

        // POST: CARRIER/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            IRCS_ARR_FLT_CARRIER iRCS_ARR_FLT_CARRIER = db.IRCS_ARR_FLT_CARRIER.Find(id);
            db.IRCS_ARR_FLT_CARRIER.Remove(iRCS_ARR_FLT_CARRIER);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
