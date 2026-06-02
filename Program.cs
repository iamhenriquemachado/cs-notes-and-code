using cs_notes_and_code.challenges.ProductSystemCrud;

ProductRepository pRepository = new ProductRepository();

int id = 10001;
string name = "Mechanical Keyboard";
decimal price = 299.90m;
int stock = 15;

pRepository.AddProduct(id, name, price, stock);

