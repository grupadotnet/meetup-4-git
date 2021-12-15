using meetup_2_asp_net_core.Models;
using meetup_2_asp_net_core.Interfaces;

namespace meetup_2_asp_net_core.Services
{
    class CommentsService : ICommentsService
    {
        public static List<Comment> Comments = new List<Comment>() {
            new Comment()
            {
                Id = 1,
                AddedAt = DateTime.Now,
                Message = "Komentarz 1"
            },
            new Comment()
            {
                Id = 2,
                AddedAt = DateTime.Now.AddHours(-2),
                Message = "Komentarz 2"
            }
        };

        public List<Comment> GetAllComments()
        {
            return Comments;
        }

        public void CreateComment(string message)
        {
            Comments.Add(new Comment
            {
                AddedAt = DateTime.Now,
                Id = 3,
                Message = message
            });

            // Composite formatting
            Console.WriteLine("Comment craeted with content {0} at {1}", message, DateTime.Now);
        }
    }
}
