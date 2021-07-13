using System; 

class URI {

    static void Main(string[] args) { 
      int a,b;
      a=int.Parse(Console.ReadLine());
      b=int.Parse(Console.ReadLine());
      saida(processamento(a,b));
    }
    static int processamento(int a,int b)
    {
      return a+b;
    }
    static void saida(int x)
    {
      Console.WriteLine("X = {0}",x);
    }
}
