using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// SET PUBLIC CLASS
/// </summary>
public class Inventory
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public Inventory(string name, decimal price, int quantity)
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

/// <summary>
/// INVENTORY LIST
/// </summary>
public class Inventory
{
    private List<Inventory> items;

    public Inventory()
    {
        items = new List<Inventory>();
    }

/// <summary>
/// ADD ITEM TO THE LIST
/// </summary>
/// <param name="name"></param>
/// <param name="price"></param>
/// <param name="quantity"></param>
    public void AddItem(string name, decimal price, int quantity)
    {
        Inventory item = new InventoryItem(name, price, quantity);
        items.Add(item);
    }

/// <summary>
/// REMOVE ITEM FROM THE LIST
/// </summary>
/// <param name="item"></param>
    public void RemoveItem(Inventory item)
    {
        items.Remove(item);
    }
    
/// <summary>
/// TOTAL PRICE OF EACH TIME
/// </summary>
/// <returns></returns>
    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (InventoryItem item in items)
        {
            totalPrice += item.TotalPrice();
        }
        return totalPrice;
    }

/// <summary>
/// PRINT INVENTORY NAME,PRICE,QUANTITY AND TOTAL PRICE
/// </summary>
    public void PrintInventory()
    {
        Console.WriteLine("Grocery List:");
        foreach (InventoryItem item in items)
        {
            Console.WriteLine($"Item: {item.Name}\tPrice: {item.Price}\tQuantity: {item.Quantity}\tTotal: {item.TotalPrice()}");
        }
        Console.WriteLine($"Total Price: {CalculateTotalPrice()}");
    }
}
