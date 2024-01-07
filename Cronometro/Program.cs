

internal class Program
{
    static void Main(string[] args)
    {

        menu();
    }


    static void menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("quanto tempo deseja contar? ");
        string data = Console.ReadLine().ToLower(); /* ToLower(); faz com que todos
						 os caracteres de string sao convertidos para minusculo.*/

        /*char type = char.Parse(data.Substring(data.Length-1 aqui ele conta 
*						quantos caracteres o usuario digitou e com -1 ele pega o ultimo caractere 
*						digitado pelo usuario, 1 aqui ele pega somente um caractere));*/

        /*int time = int.Parse(data.Substring(0 ele vai pega toda informacao do 
*		 *			inicio ate o fim determinado pelo desenvolvedor, data.Length-1 ele conta 
*		 * 			quantos caracteres o usuario digitou e exclui somente o ultimo caractere));*/

        if (!string.IsNullOrEmpty(data) && data.Length >= 2)
        {
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multplier = 1;

            if (type == 'm')
                multplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multplier);
        }
        else
        {
            // Trate a situação em que a entrada não é válida.
            Console.WriteLine("Entrada inválida.");
        }

        static void PreStart(int time)
        {

            Console.Clear();
            Console.WriteLine("preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("fogo...");
            Thread.Sleep(2500);

            Start(time);

        }
        static void Start(int time)
        {


            int currimentTime = 0;
            while (currimentTime != time)
            {

                Console.Clear();
                currimentTime++;
                Console.WriteLine(currimentTime);
                Thread.Sleep(1000);
                /*aqui o thread.sleep faz a funcao de um intervalor em milisegundos, no
                caso 1000 milisegundos daria 1 segundo de intervalo(caso nao tivessemos
                esse intervalo o processador iria fazer essa contagem muito rapido)*/
            }

            Console.Clear(); // funcao de limpar a tela e gerar um novo comando
            Console.WriteLine("Cronometro finalizado");
            Thread.Sleep(2500); // intervalod de 2,5 seg
            menu(); // retorna para o menu
        }
    }
}
