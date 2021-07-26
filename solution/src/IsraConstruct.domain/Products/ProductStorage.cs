using IsraConstruct.domain.DTOs;

namespace IsraConstruct.domain.Products{
    public class ProductStorage{

        private readonly IRepository<Product> _productRepository;
        // Repositorio é meramente um lugar onde se guarda os dados
        // A interface foi feita como um meio caminho andado, como se fosse pra implementar depois
        // ao mesmo tempo, ela serve pra nao gerar dependencia a uma classe especifica, considerando que
        // posteriormente talvez seja mudado exatamente isso
        private readonly IRepository<Category> _categoryRepository;

        public ProductStorage(IRepository<Product> productRepository,
         IRepository<Category> categoryRepository){
             _productRepository = productRepository;
             _categoryRepository = categoryRepository;
        }


        private void Store(ProductDTO dto) {
            var category = _categoryRepository.GetById(dto.CategoryId);
            DomainException.When(category == null, "Category invalid");

            var product = _productRepository.GetById(dto.Id);
            if(product == null){
                product = new Product(dto.Name, category, dto.Price, dto.StockQuantity);
                _productRepository.Save(product);
            }
            else{
                product.Update(dto.Name, category, dto.Price, dto.StockQuantity);
            }
        }

    }
}