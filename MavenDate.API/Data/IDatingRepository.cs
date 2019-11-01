using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;
using MavenDate.API.Helpers;
using MavenDate.API.Models;

namespace MavenDate.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();

         //WITHOUT PAGINATION
        //  Task<IEnumerable<User>> GetUsers();
         Task<PagedList<User>> GetUsers(UserParams userParams);

         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhtoForUser(int userId);
         Task<Like> GetLike(int userId, int recipentId);
         Task<Message> GetMessage(int id);
         Task<PagedList<Message>> GetMessagesForUser(MessageParams messageParams);
         Task<IEnumerable<Message>> GetMessageThread(int userId, int recipentId);
    }
}