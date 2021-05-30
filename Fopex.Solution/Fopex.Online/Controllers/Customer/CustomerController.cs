using System.Linq;
using System.Web.Mvc;
//using System.Data.Entity;
using System.Collections.Generic;
//using FopexOnline.Models.ItemsFolder;
using System.Data;

using Fopex.BAL.Areas.Customer;
using Fopex.DAL.Model.Customer;

namespace Fopex.Online.Controllers.Customer
{

    public class CustomerController : Controller
    {

        //  Models.Customer.FopexEntities db = new Models.Customer.FopexEntities();




        // GET: Customer
        public ActionResult Index()
        {
            //List<Customers> customerslist = db.customers.ToList<Customers>();
            //return Json(new { data = customerslist }, JsonRequestBehavior.AllowGet);

            // return View(db.customers.ToList());

            List<mCustomer> lst = new List<mCustomer>();
            BOCustomer obj = new BOCustomer();
            lst = obj.BOGetCustomer();


            return View(lst.ToList());
        }







        // GET: Customer/Details/5
        //public ActionResult Details(int CustID)
        //{
        //    return View();
        //}

        public bool BindDropDown()
        {
            try
            {

                BOCustomer objBOCustomer = new BOCustomer();

                var getcitylist = objBOCustomer.ddlGetCity();
                var ddlcitylist = new SelectList(getcitylist.ToList(), "ID", "City_Name");
                ViewBag.vbcity = ddlcitylist;

                var getcountrylist = objBOCustomer.ddlGetCountry();
                var ddlcountrylist = new SelectList(getcountrylist.ToList(), "ID", "Country_Name");
                ViewBag.vbcountry = ddlcountrylist;


                var getRegionlist = objBOCustomer.ddlGetRegion();
                var ddlregionlist = new SelectList(getRegionlist.ToList(), "ID", "Region_Name");
                ViewBag.vbRegion = ddlregionlist;







                //var mylist = cshparpEntity.itemtypes.ToList();
                //    var fromDatabaseEF = new SelectList(mylist.ToList(), "ID", "Item_Type_Code");
                //    ViewBag.MySkills = fromDatabaseEF;









                return true;

            }
            catch (System.Exception ex)
            {

                return false;
            }

        }

        //GET: Customer/Create
        public ActionResult Create()
        {
            mCustomer objCust = new mCustomer();
            bool result = BindDropDown();
            return View(objCust);
        }


        ////GET: Customer/CreateCustomer
        //public ActionResult CreateCustomer()
        //{
        //    mCustomer objCust = new mCustomer();
        //    //bool result = BindDropDown();
        //    return View(objCust);
        //}



        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(mCustomer customers)
        {
            if (ModelState.IsValid)
            {
                BOCustomer oCustomer = new BOCustomer();
                oCustomer.BOAddNewCustomer(customers);
                return RedirectToAction("Index");
            }

            return View(customers);
        }



        // GET: Customer/Edit/5
        public ActionResult Edit(int CustID)
        {
            //Customers customers = db.customers.Find(CustID);
            //if (customers == null)
            //{
            //    HttpNotFound();
            //}
            // return View(customers);

            return View();
        }

        // POST: Customer/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int CustID, Customers customers)
        //{
        //    //try
        //    //{
        //    //    if (ModelState.IsValid)
        //    //    {
        //    //        db.Entry(customers).State = EntityState.Modified;
        //    //        db.SaveChanges();
        //    //    }

        //    //    return RedirectToAction("Index");
        //    //}
        //    //catch
        //    //{
        //    //    return View();
        //    //}
        //}

        // GET: Customer/Delete/5
        public ActionResult Delete(int CustID)
        {
            //Customers customers = db.customers.Find(CustID);
            //if (customers == null)
            //{
            //    HttpNotFound();
            //}
            //return View(customers);

            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int CustID)
        {
            //Customers customers = db.customers.Find(CustID);
            //db.customers.Remove(customers);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}

