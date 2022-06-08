using System;
// Class 1
class AccountBook
{
    public string name; // Represent name
    public int age; // Repsent age
    private int balance; // Represnt balance
    private bool active; // Reprsent if account is active or not
    public Account(string name, int age)
    { // Constructor
        this.name = name;
        this.age = age;
        this.balance = 0;
        this.active = true;
    }
    public int getBalance()
    {
        return this.balance;
    }
    public bool deposit(int amount)
    { // Depositing money into the account
        if (this.active)
        {
            this.balance += amount;
            return true;
        }
        return false;
    }
    public bool withdraw(int amount)
    { // Withdraw money from the account
        if (this.active)
        {
            if (amount <= this.balance)
            {
                this.balance -= amount;
                return true;
            }
            return false;
        }
        return false;
    }
    public bool isActive()
    { // returns true if account is active
        return this.active;
    }
    public void deactivate()
    { // deactivates the account
        this.active = false;
    }
    public void activate()
    { // activate the account
        this.active = true;
    }
}
// Class 2
class Invoice
{ // class representing invoice    
    private int amount; // Amount of the invoice
    private int itemId; // Id of the item for which the invoice
    private int dateCreated; // Date of the invoice
    private string monthCreated; // Month of the invoice
    private int yearCreated; // Year of the invoice
    public Invoice(int amount, int itemId, int dateCreated, string monthCreated, int yearCreated)
    { // constructor
        this.amount = amount;
        this.itemId = itemId;
        this.dateCreated = dateCreated;
        this.monthCreated = monthCreated;
        this.yearCreated = yearCreated;
    }
    public int getItemId()
    {
        return this.itemId; // returns this item id for the invoice
    }
    public int getAmount()
    {
        return this.amount; // returns this amount for the invoice
    }
}
// Class 3
class Item
{ // class representing an Item
    private int id; // id of the item
    private int price; // price of the item
    public string name; // name of the item
    public string description; // description of the item
    public Item(int id, int price, string name, string description)
    { // constructor
        this.id = id;
        this.price = price;
        this.name = name;
        this.description = description;
    }
    public int getPrice()
    { // returns the price of the item
        return this.price;
    }
    public void changePrice(int newPrice)
    { // Changes the price of the item to newPrice
        this.price = newPrice;
    }
    public int getItemId()
    { // returns the itemId of the item
        return this.id;
    }

}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        AccountBook account = new AccountBook("test", 19); // Creating a new account
        account.deposit(100); // Depositing some money
        Item item = new Item(1, 10, "check", "Check item"); // Creating a new item
        Invoice invoice = new Invoice(10, 1, 10, "jan", 2002); // Creating a new invoide 
        Console.WriteLine("Account Balance: " + account.getBalance().ToString());
        Console.WriteLine("Invoice Amount: " + invoice.getAmount().ToString());
        Console.WriteLine("Item Price: " + item.getPrice().ToString());

    }
}