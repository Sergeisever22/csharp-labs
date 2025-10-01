Console.WriteLine("Hello, Jerry");
test1();
A();
A();
A();

void test1()
{
    Console.WriteLine("A");
    Thread.Sleep(500);
    Console.WriteLine("B");
    Thread.Sleep(500);
    Console.WriteLine("C");
    Thread.Sleep(500);
}

void A()
{
    Console.WriteLine("-");
    B();
    C();
}

void B()
{
Console.WriteLine("b");
}

void C()
{
   Console.WriteLine("c"); 
}