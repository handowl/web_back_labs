using System;
using Web.Models;

namespace Web.Services
{
    public interface IUserPermissionsService
    {
        Boolean CanEditPost(Post post);

        Boolean CanEditPostComment(PostComment postComment);
    }
}