using cs_notes_and_code.challenges.GenericsMemoryRepository;

RepositoryMemory<Product> product = new();
RepositoryMemory<Customer> customer = new();

Product pModel = new() {
    Name = "Macbook",
    Price = 100.0m,
    Id = 001
};
    
product.Add(pModel);
