using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NADShop.Data.Infrastructure;
using NADShop.Data.Repositories;
using NADShop.Model.Models;
using NADShop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategories;

        [TestInitialize]
        public void Initialize() {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategories = new List<PostCategory>()
            {
                new PostCategory(){ID = 1, Name= "Cate1", Status = true},
                new PostCategory(){ID = 2, Name= "Cate2", Status = true},
                new PostCategory(){ID = 3, Name= "Cate3", Status = true}
            };
        }

        [TestMethod]
        public void PostCategory_Service_All()
        {
            // setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategories);

            // call action
            var result = _categoryService.GetAll() as List<PostCategory>;

            // compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);

        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test";
            category.Alias = "Test";
            category.Status = true;

            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) => { p.ID = 1; return p; });

            var result = _categoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);


        }
    }
}
