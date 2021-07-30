using System.ComponentModel.DataAnnotations;

namespace IsraConstruct.mvc.ViewModels
{
    public class CategoryViewModel
    {
        public int Id {get; private set;}

        [Required]
        public string Name {get; private set;}

    }
}