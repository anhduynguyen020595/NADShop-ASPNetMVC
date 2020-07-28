using NADShop.Model.Models;
using NADShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NADShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryViewModel)
        {
            postCategory.ID = postCategoryViewModel.ID;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.DisplayOrder = postCategoryViewModel.DisplayOrder;
            postCategory.Image = postCategoryViewModel.Image;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;
            postCategory.CreatedBy = postCategoryViewModel.CreatedBy;
            postCategory.CreatedDate = postCategoryViewModel.CreatedDate;
            postCategory.UpdatedDate = postCategoryViewModel.UpdatedDate;
            postCategory.UpdatedBy = postCategoryViewModel.UpdatedBy;
            postCategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postCategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postCategory.Status = postCategoryViewModel.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Description = postViewModel.Description;
            post.Alias = postViewModel.Alias;
            post.CategoryID = postViewModel.CategoryID;
            post.Content = postViewModel.Content;
            post.Image = postViewModel.Image;
            post.HomeFlag = postViewModel.HomeFlag;
            post.ViewCount = postViewModel.ViewCount;
            post.CreatedBy = postViewModel.CreatedBy;
            post.CreatedDate = postViewModel.CreatedDate;
            post.UpdatedDate = postViewModel.UpdatedDate;
            post.UpdatedBy = postViewModel.UpdatedBy;
            post.MetaDescription = postViewModel.MetaDescription;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.Status = postViewModel.Status;
        }
    }
}