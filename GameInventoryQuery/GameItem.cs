class GameItem
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Grade { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public GameItem(string name, string type, string grade, int price, int quantity)
    {
        Name = name;
        Type = type;
        Grade = grade;
        Price = price;
        Quantity = quantity;
    }

}