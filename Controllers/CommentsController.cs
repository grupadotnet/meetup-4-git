using Microsoft.AspNetCore.Mvc;
using meetup_2_asp_net_core.Interfaces;
using meetup_2_asp_net_core.Models;

namespace meetup_2_asp_net_core.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentsService _commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        public IActionResult Index()
        {
            var comments = _commentsService.GetAllComments();

            return View(comments);
        }

        public IActionResult Name(string name, int age)
        {
            return Ok(new {
                success = true,
                response = "Ok",
                firstName = name,
                age
            });
        }

        [HttpPost]
        public IActionResult Send([FromForm] NewCommentRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _commentsService.CreateComment(request.Message);

            return Redirect("/Comments");
        }

        string Custom()
        {
            return "This won't be displayed";
        }
    }
}