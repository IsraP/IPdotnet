using System;

namespace IsraConstruct.domain.Products
{
    public class CategoryStorage
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryStorage(IRepository<Category> categoryRepository){
             _categoryRepository = categoryRepository;
        }

        public void Store(int id, string name){
            var category = _categoryRepository.GetById(id);

            if(category == null){
                category = new Category(name);
                Console.WriteLine("nome: " + name);
                _categoryRepository.Save(category);
            }
            else{
                category.Update(name);
            }
        }
    }
}