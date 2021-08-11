using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SDP.Models;

namespace SDP.Pages
{
    public class CartModel : PageModel
    {
        Customer customer = null;
        public void OnGet()
        {
            if (HttpContext.Session.GetString("Id") == null)
            {
                Models.GuestCustomer guest = new Models.GuestCustomer();
                Global.customerList.Add(guest);
                string Id = guest.ID.ToString();
                HttpContext.Session.SetString("Id", Id);
            }
            ViewData["Id"] = HttpContext.Session.GetString("Id");
            customer = PageUtil.getCustomerFromDB(HttpContext.Session.GetString("Id"));

        }

        public void OnGetCart()
        {

        }
    }
}
