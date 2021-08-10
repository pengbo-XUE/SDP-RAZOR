using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SDP.Pages
{
    public class ProductsModel : PageModel
    {
        
        public void OnGet()
        {
            if (HttpContext.Session.GetString("Id") == null)
            {
                Models.GuestCustomer guest = new Models.GuestCustomer();
                Global.guestList.Add(guest);
                string Id = guest.ID.ToString();
                HttpContext.Session.SetString("Id", Id);
            }
            ViewData["Id"] = HttpContext.Session.GetString("Id");
        }

        public IActionResult OnPostRedirect(string value)
        {
            return RedirectToPage("ProductDisplay","Display",  new { productID = value });
        }

    }
}

