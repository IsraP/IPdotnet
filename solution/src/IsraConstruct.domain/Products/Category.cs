namespace IsraConstruct.domain.Products{
    public class Category {
        public int Id {get; private set;}

        public string Name {get; private set;}

        private void ValidateAndSetName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name required");

            Name = name;
        }

        public Category(string name)
        {
            ValidateAndSetName(name);
        }

        public void Update (string name){
            ValidateAndSetName(name);
        }

    }
}