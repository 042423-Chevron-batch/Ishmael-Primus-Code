using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class GroceryItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public GroceryItem(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public decimal TotalPrice()
    {
        return Price * Quantity;
    }
}

public class GroceryList
{
    private List<GroceryItem> items;

    public GroceryList()
    {
        items = new List<GroceryItem>();
    }

    public void AddItem(string name, decimal price, int quantity)
    {
        GroceryItem item = new GroceryItem(name, price, quantity);
        items.Add(item);
    }

    public void RemoveItem(GroceryItem item)
    {
        items.Remove(item);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (GroceryItem item in items)
        {
            totalPrice += item.TotalPrice();
        }
        return totalPrice;
    }

    public void PrintGroceryList()
    {
        Console.WriteLine("Grocery List:");
        foreach (GroceryItem item in items)
        {
            Console.WriteLine($"Item: {item.Name}\tPrice: {item.Price}\tQuantity: {item.Quantity}\tTotal: {item.TotalPrice()}");
        }
        Console.WriteLine($"Total Price: {CalculateTotalPrice()}");
    }
}
