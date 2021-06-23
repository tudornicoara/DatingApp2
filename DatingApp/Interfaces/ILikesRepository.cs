using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.Dtos;
using DatingApp.Entities;
using DatingApp.Helpers;

namespace DatingApp.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(Guid sourceUserId, Guid likedUserId);
        Task<AppUser> GetUserWithLikes(Guid userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}
