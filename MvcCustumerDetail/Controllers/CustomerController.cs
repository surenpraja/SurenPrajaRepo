using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCustumerDetail.Models;

namespace MvcCustumerDetail.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult CustDetail(int id)
        {
            CustomerContext customerContext = new CustomerContext();
            Customer cust =  customerContext.Customers.Single(x => x.EmployeeID == id);
            
            return View(cust);
        }

    }
}
