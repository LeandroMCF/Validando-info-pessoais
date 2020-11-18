using System;

namespace Validando_info_pessoais
{
    class Program
    {
        static void Main(string[] args)
        {
            int rep;
            string nome;
            int idade;
            float sal;
            string ec;
            string ecc;
            string ece;
            int corre;
            int ops;
            int cor;

            rep = 1;
            ece = " ";
            while (rep == 1)
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                while (nome == "")
                {
                    Console.Write("Nome inválido \n Digite seu nome: ");
                    nome = Console.ReadLine();
                }
                Console.Write($"Olá, {nome}. Para começar, digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                while (idade < 0 && idade > 150)
                {
                    Console.WriteLine("Idade inválida, digite sua idade novamente: ");
                    idade = int.Parse(Console.ReadLine());
                }
                Console.Write("Agora, digite o seu salário: \nR$");
                sal = float.Parse(Console.ReadLine());
                while (sal <= 0)
                {
                    Console.Write("Salário inválido. digite seu salário novamente: \nR$");
                    sal = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("Estamos quase acabando. \n Agora, informe o seu estado civil: \n [S] Para solteiro(a) \n [C] Para casado(a) \n [V] Para viuvo(a) \n [D] Para divorciado(a)");
                ec = Console.ReadLine();
                ecc = ec.ToUpper();
                while (ecc != "S" && ecc != "C" && ecc != "V" && ecc != "D")
                {
                    Console.WriteLine("Opção inválida. Digite a opção novamente: \n [S] Para solteiro(a) \n [C] Para casado(a) \n [V] Para viuvo(a) \n [D] Para divorciado(a)");
                    ec = Console.ReadLine();
                    ecc = ec.ToUpper();
                }
                switch (ecc)
                {
                    case "S":
                        ece = "solteiro(a)";
                        break;
                    case "C":
                        ece = "casado(a)";
                        break;
                    case "V":
                        ece = "viuvo(a)";
                        break;
                    case "D":
                        ece = "divorciado(a)";
                        break;
                }
                cor = 1;
                while (cor == 1)
                {
                    Console.WriteLine($"--------------------- \n Revisão \n --------------------- \n Seu nome é {nome} \n Você tem {idade} anos \n Seu salário é R${sal} \n E seu estadocivil é {ece} \n ---------------------");
                    Console.WriteLine("Deseja corrigir alguma informação? \n [1] Para corrigir [2] Para não corrigir");
                    corre = int.Parse(Console.ReadLine());
                    while (corre != 1 && corre != 2)
                    {
                        Console.WriteLine("Opção inválida, digite a opção novamente. \n [1] Para corrigir [2] Para não corrigir");
                        corre = int.Parse(Console.ReadLine());
                    }
                    while (corre == 1)
                    {
                        Console.WriteLine("O que deseja corrigir? \n [1] Nome \n [2] Idade \n [3] Salário \n [4] Estado Civil");
                        ops = int.Parse(Console.ReadLine());
                        while (ops != 1 && ops != 2 && ops != 3 && ops != 4)
                        {
                            Console.WriteLine("Opção inválida, digite a opção novamente. \n [1] Nome \n [2] Idade \n [3] Salário \n [4] Estado Civil");
                            ops = int.Parse(Console.ReadLine());
                        }
                         switch (ops)
                        {
                            case 1:
                                Console.Write("Digite seu nome: ");
                                nome = Console.ReadLine();
                                while (nome == "")
                                {
                                    Console.Write("Nome inválido \n Digite seu nome: ");
                                    nome = Console.ReadLine();
                                }
                            break;
                            case 2:
                                Console.Write("Digite sua idade: ");
                                idade = int.Parse(Console.ReadLine());
                                while (idade < 0 && idade > 150)
                                {
                                    Console.WriteLine("Digite sua idade novamente: ");
                                    idade = int.Parse(Console.ReadLine());
                                }
                            break;
                            case 3:
                                Console.Write("Digite o seu salário: \nR$");
                                sal = float.Parse(Console.ReadLine());
                                while (sal <= 0)
                                {
                                    Console.Write("Salário inválido. digite seu salário novamente: \nR$");
                                    sal = float.Parse(Console.ReadLine());
                                }
                            break;
                            case 4:
                                Console.WriteLine("Estamos quase acabando. \n Agora, informe o seu estado civil: \n [S] Para solteiro(a) \n [C] Para casado(a) \n [V] Para viuvo(a) \n [D] Para     divorciado(a)");
                                ec = Console.ReadLine();
                                ecc = ec.ToUpper();
                                while (ecc != "S" && ecc != "C" && ecc != "V" && ecc != "D")
                                {
                                    Console.WriteLine("Opção inválida. Digite a opção novamente: \n [S] Para solteiro(a) \n [C] Para casado(a) \n [V] Para viuvo(a) \n [D] Para divorciado(a");
                                    ec = Console.ReadLine();
                                    ecc = ec.ToUpper();
                                }
                                switch (ecc)
                                {
                                    case "S":
                                        ece = "solteiro(a)";
                                        break;
                                    case "C":
                                        ece = "casado(a)";
                                        break;
                                    case "V":
                                        ece = "viuvo(a)";
                                        break;
                                    case "D":
                                        ece = "divorciado(a)";
                                        break;
                                }
                            break;
                        }
                        Console.WriteLine("Deseja corrigir mais alguma coisa? \n [1] Sim \n Qualquer numero para encerrar");
                        corre = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Deseja ver a Revisão? \n [1] Sim \n Qualquer numero para encerrar");
                    cor = int.Parse(Console.ReadLine());
                    if (cor != 1)
                    {
                        Console.WriteLine("Ok, obrigado por se cadastrar!");
                    }
                }
                Console.Write("Deseja cadastrar mais alguém? \n [1] Sim \n Qualquer número para não");
                rep = int.Parse(Console.ReadLine());
            }
            Console.Write("Fim");
        }
    }
}
