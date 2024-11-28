
namespace Lexicon_AB_Checkpoint_2_Produktlista_1
{


public class Product
{

    public string Category { get; set; } 
    public string Name { get; set; }
    public double Price { get; set; }



    public Product(string category, string name, double price)
    {
        Category = category;
        Name = name;
        Price = price;

    }


    public override string ToString()
    {

        return $"{Category} - {Name} - SEK{Price:F2}";

    }

    

}
}
