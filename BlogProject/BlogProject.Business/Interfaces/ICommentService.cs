using BlogProject.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Business.Interfaces
{
    public interface ICommentService : IGenericService<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
