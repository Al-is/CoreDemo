using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using DataAccessLayer.EntityFramework;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        private EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
