//List<string> InMyInventory = new List<string>();
//List<MyInventory> InMyInventory = new List<MyInventory>(0);

//InMyInventory.Add("Electronic", "Razer", 500);

////if readline then add object to class list MyInventory when "q"uit show MyInventory 
//Console.ForegroundColor(yellow);
//MyInventory2 myInventory2;
//int index = 0;

//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine("To enter a new product - follow the steps | To quit - enter: 'Q' ");

//while (true)
//{

//    Console.ResetColor();
//    string input = Console.ReadLine();

//    if (input.Trim().ToLower() == "q")
//    {
//        break;
//    }


//    if (input.Length != 1)
//    {
//        Console.Write("Enter your category: ");
//        InMyInventory.Add(input)
//        continue;
//    }


//    if (input.Length != 0)
//    {
//        Console.Write("Enter your product name: ");
//        continue;
//    }

//    if (input.Length != 0)
//    {
//        Console.Write("Enter your price: ");
//        myInventory2.Add();
//        continue;
//    }

//    if (input.Length != 0)
//    {
//        index++;
//    }


//}


//class MyInventory
//{

//    public string Category { get; set; }
//    public string Name { get; set; }
//    public int Price { get; set; }


//}

//class MyInventory2
//{
//    public MyInventory2(List<MyInventory> inventory)
//    {
//        Inventory = inventory;
//    }

//    public List<MyInventory> Inventory { get; set; }


//}

namespace Lexicon_AB_Checkpoint_2_Produktlista_1
{

    class InMyInventory
    {


        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            while (true)
            {
                string input = "";
                string category = "";
                string name = "";
                double price = 0;

                InMyInventory.AddProduct(input, category, name, price, productList);

                Console.WriteLine("---------------------- ");


                List<Product> sortedProducts = new List<Product>();

                sortedProducts = productList.OrderBy(x => x.Price).ToList();

                double sum = 0;

                foreach (var product in sortedProducts)
                {

                    Console.WriteLine(product);
                    sum += product.Price;

                }

                Console.WriteLine("SEK: " + sum);
                Console.WriteLine("Do you want to enter another product?: Yes/No");
                string newInput = Console.ReadLine().ToLower();
                if (newInput == "no" || newInput.ToLower() == "q")
                {
                    break;
                }

            }
        }


        public static void AddProduct(string input, string category, string name, double price, List<Product> productList)
        {

            while (true)
            {

                Console.Write("Enter your category: ");
                input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }
                else if (string.IsNullOrEmpty(input)) { continue; }
                category = input;

                Console.Write("Enter your product name: ");
                input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }
                else if (string.IsNullOrEmpty(input)) { continue; }
                name = input;



                //checks if it a q or a string then tryparse input into a double
                while (true)
                {

                    Console.Write("Enter your price: ");
                    input = Console.ReadLine();

                    if (input.ToLower() == "q")
                    {
                        break;

                    }
                    else if (string.IsNullOrEmpty(input)) { continue; }

                    if (double.TryParse(input, out price) && price >= 0)
                    {
                        break;
                    }

                }
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("The product was successfully added!");
                ////The product was successfully added!
                //Console.ResetColor();

                //Console.WriteLine("Enter your category: " + category);
                //Console.WriteLine("Enter your product name: " + name);
                //Console.WriteLine("Enter your price: " + price);

                //Console.ReadKey();

                Product newProduct = new Product(category, name, price);
                productList.Add(newProduct);

                Console.WriteLine("Do you want to enter another product?: Yes/No");
                string newInput = Console.ReadLine().ToLower();
                if (newInput == "no" || newInput.ToLower() == "q")
                {
                    break;
                }
            }

        }

    }

}

