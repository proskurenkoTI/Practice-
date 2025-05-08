using System;

class Product
{
    public string Name;
    public string Category;
    public string Ingredients;
    public int ShelfLife;

    public Product(string Name, string Category, string Ingredients, int ShelfLife)
    {
        this.Name = Name;
        this.Category = Category;
        this.Ingredients = Ingredients;
        this.ShelfLife = ShelfLife;
    }
}