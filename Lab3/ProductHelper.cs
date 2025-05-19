    using System;


class ProductHelper
{
    List<Product> list = new List<Product>();
    public List<Product> CheckIngredients(List<Product> products,  string component)
    {
        foreach(var product in products) 
        {
            if (product.Ingredients.Contains(component))
            {
                list.Add(product);
            }
        }
        return list;
    }
    public Dictionary<string, int> SearchProductTypesCategory(List<Product> products)
    {
        var categoryCounter = new Dictionary<string, int>();
        foreach(var product in products)
        {
            if (categoryCounter.ContainsKey(product.Category))
            {
                categoryCounter[product.Category]++;
            }
            else
            {
                categoryCounter[product.Category] = 1;
            }
        }
        return categoryCounter;
    }
    public List<Product> SortShelLifeDescending(List<Product> products)
    {
        int n = products.Count;
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                Product temp = products[i];
                int j;
                for (j = i; j >= gap && products[j - gap].ShelfLife < temp.ShelfLife; j -= gap)
                {
                    products[j] = products[j - gap];
                }
                products[j] = temp;
            }
            gap /= 2;
        }
        return products;
    }
    public void PrintProducts(List<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Category);
            Console.WriteLine(product.Ingredients);
            Console.WriteLine(product.ShelfLife);
            Console.WriteLine("**********************************");
        }
    }
    public void PrintProductsSearchCategory(Dictionary<string, int> categoryCounter)
    {
        foreach(var category in categoryCounter)
        {
            Console.WriteLine($"{category.Key}: {category.Value}");
        }
    }

}