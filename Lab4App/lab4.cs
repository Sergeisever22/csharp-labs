// See https://aka.ms/new-console-template for more information
test1();
test2();
test3();

void test1()
{
    int a = 5;
    int b = 6;
    a = b;
    b = 7;
    Console.WriteLine(a);
    Console.WriteLine();
}

void test2()
{
    int a = 5;
    int b = a + 6;
    a = 7;
    Console.WriteLine(b);
    Console.WriteLine();
}

void test3()
{
    string a = "a";
    string b = a;
    a = "b";
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine();
}

//string a = 5;