using System;

class Program
{
    public static string? testeString;
    public static int? testeInteiro1;
    public static int testeInteiro2;
    public static DateTime? testeDateTime;

    public static void Main(){
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //PRIMEIRO ROUND
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        int i =10;
        Console.WriteLine("valor de i é " + i);
        string texto = "Edson";
        Console.WriteLine("valor de texto é " + texto);

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //SEGUNDO ROUND
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        string first="algo";
        Console.WriteLine("valor de first é " + first);
        string second = string.Empty;
        Console.WriteLine("valor de second é " + second);
        int third=0;
        Console.WriteLine("valor de third é " + third);
        DateTime date=DateTime.MinValue;
        Console.WriteLine("valor de first é " + date);

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //TERCEIRO ROUND
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        int? primeiro=1;
        int? segundo=null;
        int? terceiro=default;
        int? quarto=new();

        Console.WriteLine("valor de primeiro é " + primeiro);
        Console.WriteLine("valor de segundo é " + segundo);
        Console.WriteLine("valor de terceiro é " + terceiro);
        Console.WriteLine("valor de quarto é " + quarto);

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //QUARTA ROUND
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        string textoUm = string.Empty;
        string textoDois = null;
        string? textoTres = null;

        Console.WriteLine("valor de textoUm é " + textoUm);
        Console.WriteLine("valor de textoDois é " + textoDois);
        Console.WriteLine("valor de textoTres é " + textoTres);

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //QUINTO ROUND
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        string textoQuatro = "Edson Moreno";
        Console.WriteLine("valor de textoQuatro é {0} tem o tamanho {1}.", textoQuatro, textoQuatro.Length);

        textoQuatro=null;
        Console.WriteLine($"valor de textoQuatro é {(textoQuatro??"OBJETO NULO")} tem o tamanho { ((textoQuatro==null)?"SEM VALOR":textoQuatro.Length) }. ");

        textoQuatro="Dell ITAcademy 17!";
        Console.WriteLine($"valor de textoQuatro é {(textoQuatro??"OBJETO NULO")} tem o tamanho {((textoQuatro==null)?"SEM VALOR":textoQuatro.Length)}.");

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //SEXTO ROUND
        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        Console.WriteLine("valor de testeString é {0}.", testeString);
        Console.WriteLine("valor de testeInteiro1 é {0}.", testeInteiro1);
        Console.WriteLine("valor de testeInteiro2 é {0}.", testeInteiro2);
        Console.WriteLine("valor de testeDateTime é {0}.", testeDateTime);

        /*
        // OPERAÇÃO INVÁLIDA: Variáveis locais requerem inicialização explícita
        int? teste1;
        int teste2;
        Console.WriteLine("valor de teste1 é {0}.", teste1);
        Console.WriteLine("valor de teste2 é {0}.", teste2);
        */
        Double measurement=6;

        switch (measurement)
            {
                case < 0.0:
                    Console.WriteLine($"Measured value is {measurement}; too low.");
                    break;

                case > 15.0:
                    Console.WriteLine($"Measured value is {measurement}; too high.");
                    break;

                case double.NaN:
                    Console.WriteLine("Failed measurement.");
                    break;

                default:
                    Console.WriteLine($"Measured value is {measurement}.");
                    break;
            }

            /*
            // VALIDAÇÃO DO SWITCH SEM BREAK ENTRE OS CASES - NÃO É VÁLIDO
            int valor=1;
            switch (valor)            {
                case 1:
                    Console.WriteLine(" o valor é 1");
                case 2:
                    Console.WriteLine(" o valor é 2");
                case 3:
                    Console.WriteLine(" o valor é 3");
                case 4:
                    Console.WriteLine(" o valor é 4");
                case 5:
                    Console.WriteLine(" o valor é 5");
                default:
                    Console.WriteLine(" o valor é default");
            }
            */

    }
}