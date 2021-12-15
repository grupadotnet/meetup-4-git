using meetup_2_asp_net_core.Models;

namespace meetup_2_asp_net_core.Interfaces
{
    public interface ICommentsService
    {
        List<Comment> GetAllComments();

        void CreateComment(string message);
    }
}
