using Microsoft.AspNetCore.Mvc;

namespace ActionReturns.Controllers
{
    public class MovieController : Controller
    {
        // Actions : public non-Static Method
        // All Actions Inherite From ActionResult
        //public ContentResult GetMoive(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Moive With Id {id}",
        //        ContentType = "Text/html",
        //        StatusCode = 200
        //    };
        //    return contentResult;
        //}
        //public RedirectResult Moive(int id)
        //{
        //    var redirectResult = new RedirectResult( "https://www.Google.com/" );
        //    return redirectResult;
        //}
        /// I Want To Make This 2 Functions in one 


        // You Have To Use The ParentClass As The Type --> ActionResult
        // Or Use The InterFace --> IActionResult  ***Recommened***
        public IActionResult GetMoive(int id)
        {
            if (id == 1)
            {
                return new ContentResult()
                {
                    Content = $"Get Movie With Id {id}",
                    ContentType = "Text/html",
                    StatusCode = 200
                };
            }
            else if (id == 2)
            {
                return new RedirectResult("https://google.com/");

            }
            else
            {
                return new RedirectToActionResult("GetMoive", "Moive", new { id = 1 });
            }
        }
        // Syntax Sugar :::
        // You Can Remove Action And It WIll Be normal Function
        public IActionResult AddMoive(int id)
        {
            if (id == 1)
            {
                return Content($"Get Moive With Id {id}", "Text/html");

            }
            else if (id == 2)
            {
                return Redirect("https://google.com/");

            }
            else
            {
                return RedirectToAction("GetMoive", "Moive", new { id = 1 });
            }
        }

        /// You Dont Have To Write This Long Name In Url 
        /// You Can Use Attruibute
        [ActionName("MoiveDetails")]
        // Now You Can Use /MoiveDetails/id
        //Not /KnowDetailsOfMoiveByHisId/id
        public ActionResult KnowDetailsOfMoiveByHisId(int id)
        {
            return Content("Hello");
        }

    }

    // Action Parameter Binding :
    // 1. Form
    // 2. Segment
    // 3. Query Params
    // 4. Files
}
