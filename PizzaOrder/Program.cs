


class Program
{
    static async Task Main(string[] args)
    {

        NpolyonPizza();
        alcsander();
        Avrahm();
       

        Thread.Sleep(180000);

    }

    static async Task NpolyonPizza()
    {
        string pizza = "napolyon";
        for (int i = 60; i > 0; i -= 10)
        {
            Console.WriteLine($"the pizza : {pizza} will be ready in {i} seconds ");
            await Task.Delay(10000);
           
        }
        Console.WriteLine(" npolyon is ready");

       

        

    }

    static async Task alcsander()
    {

        string pizzaa = "Alcsander";
        for (int i = 120; i > 0; i-= 10)
        {
            Console.WriteLine($"the pizza : {pizzaa} will be ready in {i} seconds ");
            await Task.Delay(10000);
        }
        Console.WriteLine(" alecsander is ready");



    }

    static async Task Avrahm()
    {
        
        string pizzaaa = "Avrham";
        for (int i = 180; i > 0; i -= 10)
        {
            Console.WriteLine($"the pizza : {pizzaaa} will be ready in {i} seconds ");
            await Task.Delay(10000);
        }
        Console.WriteLine("avraham is ready");


    }
}
