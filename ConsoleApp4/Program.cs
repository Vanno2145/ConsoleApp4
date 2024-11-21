using System;

public class Card
{
    public string Number { get; private set; }
    public string Owner { get; private set; }
    public DateTime ValidUntil { get; private set; }
    private string PinCode { get; set; }
    public int Limit { get; private set; }
    public int Balance { get; private set; }

    public event Action<int> OnTopUp;
    public event Action<int> OnSpend;
    public event Action OnCreditUsed;
    public event Action OnBalanceReached;

    public Card(string number, string owner, DateTime validUntil, string pinCode, int limit, int startBalance)
    {
        Number = number;
        Owner = owner;
        ValidUntil = validUntil;
        PinCode = pinCode;
        Limit = limit;
        Balance = startBalance;
    }

    public bool CheckPin(string pin)
    {
        return PinCode == pin;
    }

    public bool Buy(int amount, string pin)
    {
        if (!CheckPin(pin))
        {
            Console.WriteLine("Неверный PIN.");
            return false;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Сумма должна быть больше нуля.");
            return false;
        }

        if (Balance + amount > Limit)
        {
            Console.WriteLine("Превышен лимит.");
            return false;
        }

        Balance += amount;
        OnSpend?.Invoke(amount);
        return true;
    }

    public void TopUp(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Сумма пополнения должна быть больше нуля.");
            return;
        }

        Balance += amount;
        OnTopUp?.Invoke(amount);

        if (Balance >= Limit)
        {
            OnBalanceReached?.Invoke();
        }
    }

    public void StartUsingCredit()
    {
        if (Balance == 0)
        {
            Console.WriteLine("Баланс на карте пуст.");
            return;
        }

        if (Balance < Limit)
        {
            OnCreditUsed?.Invoke();
        }
    }

    public void ChangePin(string oldPin, string newPin)
    {
        if (CheckPin(oldPin))
        {
            PinCode = newPin;
            Console.WriteLine("PIN изменен успешно.");
        }
        else
        {
            Console.WriteLine("Неверный старый PIN.");
        }
    }

    public void OnBalanceReplenished(int amount)
    {
        Console.WriteLine($"[Событие] Баланс пополнен на сумму: {amount}.");
    }

    public void OnMoneySpent(int amount)
    {
        Console.WriteLine($"[Событие] Потрачено: {amount}.");
    }

    public void OnCreditStarted()
    {
        Console.WriteLine("[Событие] Начало использования кредита.");
    }

    public void OnBalanceLimitReached()
    {
        Console.WriteLine("[Событие] Достигнут лимит.");
    }

    public override string ToString()
    {
        return $"Карта: {Number}, Владелец: {Owner}, Срок действия: {ValidUntil.ToString("MM/yy")}, Баланс: {Balance}, Лимит: {Limit}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Card card = new Card(
            "1234 5678 9101 1121",
            "Иван Иванов",
            new DateTime(2026, 12, 31),
            "1234",
            50000,
            1000
        );

        card.OnTopUp += card.OnBalanceReplenished;
        card.OnSpend += card.OnMoneySpent;
        card.OnCreditUsed += card.OnCreditStarted;
        card.OnBalanceReached += card.OnBalanceLimitReached;

        Console.WriteLine("Пополнение счета на 2000");
        card.TopUp(2000);

        Console.WriteLine("Попытка покупки на 1500");
        card.Buy(1500, "1234");

        Console.WriteLine("Пополнение счета на 40000");
        card.TopUp(40000);

        Console.WriteLine("Начало использования кредита");
        card.StartUsingCredit();

        Console.WriteLine("Изменение PIN");
        card.ChangePin("1234", "5678");

        Console.WriteLine("Попытка покупки на 10000");
        card.Buy(10000, "5678");

        Console.WriteLine("Текущая информация о карте:");
        Console.WriteLine(card);
    }
}
