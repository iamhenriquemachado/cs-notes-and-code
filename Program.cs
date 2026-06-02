using cs_notes_and_code.challenges.ProductSystemCrud;

ProductRepository pRepository = new ProductRepository();


string name = "Mechanical Keyboard";
decimal price = 299.90m;
int stock = 15;

pRepository.AddProduct(name, price, stock);
