// FoodItem.cs
public class FoodItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public double Calories { get; set; }
    public double Protein { get; set; }
    public double Carbs { get; set; }
    public double Fat { get; set; }

    public FoodItem(string name, double price, double calories, double protein, double carbs, double fat)
    {
        Name = name;
        Price = price;
        Calories = calories;
        Protein = protein;
        Carbs = carbs;
        Fat = fat;
    }
}
