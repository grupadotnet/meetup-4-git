using System.Collections.Generic;
using meetup_4_asp_net_core.Models;

namespace meetup_4_asp_net_core.Interfaces
{
    public interface ICommentsService
    {
        List<Comment> GetAllComments();

        void CreateComment(string message);
    }
}
