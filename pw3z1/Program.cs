using System;

public class pw3z1
{
    private const int MaxLength = 250;
    private const int ShortMessageLength = 65;
    private const decimal ShortMessagePrice = 1.5m;
    private const decimal AdditionalCharPrice = 0.5m;

    private string _messageText;
    private decimal _price;

    public string MessageText
    {
        get { return _messageText; }
        set { _messageText = value?.Substring(0, Math.Min(value.Length, MaxLength)); }
    }

    public decimal Price
    {
        get { return _price; }
    }

    public void CalculatePrice()
    {
        int messageLength = _messageText.Length;

        if (messageLength <= ShortMessageLength)
        {
            _price = ShortMessagePrice;
        }
        else
        {
            int additionalChars = messageLength - ShortMessageLength;
            decimal additionalCost = additionalChars * AdditionalCharPrice;
            _price = ShortMessagePrice + additionalCost;
        }
    }
}