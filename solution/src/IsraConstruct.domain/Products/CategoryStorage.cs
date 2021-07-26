using IsraConstruct.domain.DTOs;

namespace IsraConstruct.domain.Products
{
    public class CategoryStorage
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryStorage(IRepository<Category> categoryRepository){
             _categoryRepository = categoryRepository;
        }

        public void Store(CategoryDTO dto){
            var category = _categoryRepository.GetById(dto.Id);

            if(category == null){
                category = new Category(dto.Name);
                _categoryRepository.Save(category);
            }
            else{
                category.Update(dto.Name);
            }
        }
    }
}