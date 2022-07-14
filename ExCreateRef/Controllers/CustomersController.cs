using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace ExCreateRef.Controllers
{
    public class CustomersController : ODataController
    {
        [AcceptVerbs("POST", "PUT")]
        public ActionResult CreateRef([FromRoute] int key, [FromRoute] string navigationProperty, [FromBody] Uri link)
        {
            return Ok();
        }
    }
}
