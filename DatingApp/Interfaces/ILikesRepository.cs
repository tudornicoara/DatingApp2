using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.Dtos;
using DatingApp.Entities;

namespace DatingApp.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(Guid sourceUserId, Guid likedUserId);
        Task<AppUser> GetUserWithLikes(Guid userId);
        Task<IEnumerable<LikeDto>> GetUserLikes(string predicate, Guid userId);
    }
}
