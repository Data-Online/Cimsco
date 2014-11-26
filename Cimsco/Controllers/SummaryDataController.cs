using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cimsco.Models;
using System.Collections;

namespace Cimsco.Controllers
{
    public class SummaryDataController : Controller
    {
        private Entities db = new Entities();

        public ArrayList GetData()
        {
            ArrayList dataTable = new ArrayList();
            dataTable.Add(new ChartData("Jan", 42, 27, 3.03));
            dataTable.Add(new ChartData("Feb", 44, 28, 2.48));
            dataTable.Add(new ChartData("Mar", 53, 35, 3.23));
            dataTable.Add(new ChartData("Apr", 64, 44, 3.15));
            dataTable.Add(new ChartData("May", 75, 54, 4.13));
            dataTable.Add(new ChartData("Jun", 83, 63, 3.23));
            dataTable.Add(new ChartData("Jul", 87, 68, 4.13));
            dataTable.Add(new ChartData("Aug", 84, 66, 4.88));
            dataTable.Add(new ChartData("Sep", 78, 59, 3.82));
            dataTable.Add(new ChartData("Oct", 67, 48, 3.07));
            dataTable.Add(new ChartData("Nov", 55, 38, 2.83));
            dataTable.Add(new ChartData("Dec", 45, 29, 2.8));
            return dataTable;
        }



        private class ChartData
        {

            private String xmonth;



            public String Xmonth
            {

                get { return xmonth; }

                set { xmonth = value; }

            }



            private double precipitation;



            public double Precipitation
            {

                get { return precipitation; }

                set { precipitation = value; }

            }



            private double high;



            public double High
            {

                get { return high; }

                set { high = value; }

            }



            private double low;



            public double Low
            {

                get { return low; }

                set { low = value; }

            }



            public ChartData(String xdate, double high, double low, double precipitation)
            {

                this.Xmonth = xdate;

                this.Precipitation = precipitation;

                this.High = high;

                this.Low = low;

            }

        }

 


        
        // GET: SummaryData
        public ActionResult Index()
        {
            var DataSource = GetData();

            var zz = db.SummaryData
                        .Where( s => s.CustomerId == 2)
                        .Select(s => new {  s.Date, s.Value1, s.Value2, s.Value3 })
                        .ToList();
            ViewBag.datasource = zz; // DataSource;
            //return View();
            return View(db.SummaryData.ToList());
        }

        // GET: SummaryData/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SummaryData summaryData = db.SummaryData.Find(id);
            if (summaryData == null)
            {
                return HttpNotFound();
            }
            return View(summaryData);
        }

        // GET: SummaryData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SummaryData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SummaryDataId,Date,Value1,Value2,Value3,Value4,Value5,CustomerId")] SummaryData summaryData)
        {
            if (ModelState.IsValid)
            {
                db.SummaryData.Add(summaryData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(summaryData);
        }

        // GET: SummaryData/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SummaryData summaryData = db.SummaryData.Find(id);
            if (summaryData == null)
            {
                return HttpNotFound();
            }
            return View(summaryData);
        }

        // POST: SummaryData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SummaryDataId,Date,Value1,Value2,Value3,Value4,Value5,CustomerId")] SummaryData summaryData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(summaryData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(summaryData);
        }

        // GET: SummaryData/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SummaryData summaryData = db.SummaryData.Find(id);
            if (summaryData == null)
            {
                return HttpNotFound();
            }
            return View(summaryData);
        }

        // POST: SummaryData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SummaryData summaryData = db.SummaryData.Find(id);
            db.SummaryData.Remove(summaryData);
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
