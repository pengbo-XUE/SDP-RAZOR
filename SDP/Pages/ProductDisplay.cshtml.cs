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
    public class ProductDisplayModel : PageModel
    {
        [BindProperty(Name = "productID", SupportsGet = true)]
        public string productID { get; set; }
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
        }
        
        public void OnGetDisplay()
        {
            ViewData["ProductID"] = productID;
            HttpContext.Session.SetString("ProductID", productID);
        }
        public IActionResult OnPostAddToCart(int quantity)
        {
            Product product = null;
            product = PageUtil.getProductFromDB(HttpContext.Session.GetString("ProductID"));
            for (int i = 0; i < quantity; i++)
            {
                PageUtil.getCustomerFromDB(HttpContext.Session.GetString("Id")).cart.addToCart(product);
            }
            return RedirectToPage("Products");
        }
    }
}
