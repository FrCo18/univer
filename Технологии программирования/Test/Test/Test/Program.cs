class Program
{
    public static void Main(string[] args)
    {
        //Child child = new Child();
        //child.Test();

        //Base base1 = child;
        //base1.Test();
        ExtendInterface extend = new ExtendInterface();
    }
}

class Base
{
    public void Test()
    {
        Console.WriteLine("Базовый");
    }
}

class Child : Base
{
    public void Test()
    {
        Console.WriteLine("Ребёнок");
    }
}

interface BaseInterface
{
    public int Test();
}

interface BaseInterface2
{
    public int Test();
}

interface ChildInterface1: BaseInterface
{

}

interface ChildInterface2 : ChildInterface1, BaseInterface2
{
    public int Test2(int x);
}

class ExtendInterface : ChildInterface2
{

    public int Test()
    {
        throw new NotImplementedException();
    }

    public int Test2(int x)
    {
        throw new NotImplementedException();
    }
}