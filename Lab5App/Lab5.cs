// See https://aka.ms/new-console-template for more information

// Цены на товары

Choices price = new()
{
    fanta = 12,
    cola = 15,
    cips = 22,
};
// Выбор клиентов

Client client1 = new()
{
    FantaCount = 1,
    ColaCount = 0,
    CipsCount = 2,
};

Client client2 = new()
{
    FantaCount = 0,
    ColaCount = 2,
    CipsCount = 2,
};

//функция вычисляющая сумму цены всех покупок 
void ClientOrder()
{
    int ClientOrder1 = client1.FantaCount * price.fanta + client1.ColaCount * price.cola + client1.CipsCount * price.cips;
    int ClientOrder2 = client2.FantaCount * price.fanta + client2.ColaCount * price.cola + client2.CipsCount * price.cips;
    Console.WriteLine(ClientOrder1);
    Console.WriteLine();
    Console.WriteLine(ClientOrder2);
}

ClientOrder();
//Какие товары существуют
struct Choices
{
    public int fanta;
    public int cola;
    public int cips;
}

// что может выбрать клиент
struct Client
{
    public int FantaCount;
    public int ColaCount;
    public int CipsCount;
}