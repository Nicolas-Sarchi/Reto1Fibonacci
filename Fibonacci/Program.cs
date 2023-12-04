//1. Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-
//ésimo número de Fibonacci:

static List<int> Fibonacci(int n)
{
     if (n == 0)
    {
        List<int> secuencia = new();
        secuencia.Add(0);
        return secuencia;
    }
    else if (n == 1)
    {
        List<int> secuencia = new();
        secuencia.Add(1);
        return secuencia;
    }
    else
    {
        List<int> secuencia = new();
        secuencia.Add(0);
        secuencia.Add(1);
        for (int i = 2; i <= n; i++)
        {
            int f = secuencia[i - 1] + secuencia[i - 2];
            secuencia.Add(f);

        }
        return secuencia;
    }
    
}

Console.WriteLine("Ingrese un numero natural: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"F{n} = {Fibonacci(n)[n]}");



static void IsFibonacci(int n)
{
   
         List<int> secuencia = new ();

        for (int i = 0; Fibonacci(i)[(Fibonacci(i).Count() - 1)] <= n; i++)
        {
                
             secuencia = Fibonacci(i);
        
        }
        if(secuencia[(secuencia.Count() - 1)] == n)
                Console.WriteLine($"{n} Es un número Fibonacci ");
            else{
                Console.WriteLine($"{n} NO Es un número Fibonacci ");

            }

}

// IsFibonacci(78);



static void mPrimerosFibonacci(int m){

    foreach(int i in Fibonacci(m)){
        Console.WriteLine(i);
    }

} 

// mPrimerosFibonacci(11);






