using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.Dtos;
using DatingApp.Entities;

namespace DatingApp.Interfaces
{
    public interface IPhotoRepository
    {
        Task<Photo> GetPhotoById(Guid id);
        Task<IEnumerable<PhotoForApprovalDto>> GetUnapprovedPhotos();
        void RemovePhoto(Photo photo);
    }
}
