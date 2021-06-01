using System.Linq;
using System.Web.Mvc;
//using System.Data.Entity;
using System.Collections.Generic;
//using FopexOnline.Models.ItemsFolder;
using System.Data;

using Fopex.BAL.Areas.Customer;
using Fopex.DAL.Model.Customer;
using Fopex.COMMON.Helper;

namespace Fopex.Online.Controllers.Customer
{

    public class CustomerController : Controller
    {

        // GET: Customer
        public ActionResult Index()
        {
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
        public ActionResult Update(mCustomer mCustome)
        {
            //Customers customers = db.customers.Find(CustID);
            //if (customers == null)
            //{
            //    HttpNotFound();
            //}
            // return View(customers);
            bool result = BindDropDown();
            return View(mCustome);
        }






        //POST: Customer/Edit/5
        //[HttpPost]
        public ActionResult Edit(int CustID,string objAction)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BOCustomer BOCustomer = new BOCustomer();
                    mCustomer modelCustomer = new mCustomer();

                    if (objAction == PageAction.View)
                    {
                        modelCustomer = BOCustomer.BOGetCustomerbyID(CustID);
                        bool result = BindDropDown();

                        return View("Update", modelCustomer);
                    }
                    if (objAction == PageAction.Edit)
                    {
                        return RedirectToAction("Index");
                        //db.Entry(customers).State = EntityState.Modified;
                        //db.SaveChanges();
                    }
                   // return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(long CustID)
        {
            bool result = false;
            if (ModelState.IsValid)
            {

                BOCustomer oCustomer = new BOCustomer();
                result = oCustomer.BODeleteCustomer(CustID);

                if (result)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    //ModelState.AddModelError("Sucess", "Data Save Sucessfully");
                    return View();
                }

            }
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

