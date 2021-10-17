using System;

namespace DesafioCsharp_CeADevs
{
    class Program
    {     


        static void Main(string[] args)
        {
            int opcoes;
            double peso;
            double altura;
            double resultado;            
            double salario;
            double salarioMinimo;
            double raio;
            double p1;
            double p2;
            double p3;
            double media;
            double mediaExame;
            double notaExame;
            string nome;
            string tipo;

            bool validacao = true;
            Program program = new Program();



            Console.WriteLine("### Olá! Seja bem vindo à minha resolução do DESAFIO C# ###");
            Console.WriteLine("### Criado por Bruno Santana Lopes ###");

            do
            {
                Console.WriteLine("\nEscolha o desafio desejado: ");
                Console.WriteLine("Desafio: (1) Cálculo de IMC.");
                Console.WriteLine("Desafio: (2) Razão entre salário e salário mínimo.");
                Console.WriteLine("Desafio: (3) Cálculo de volume esférico.");
                Console.WriteLine("Desafio: (4) Cálculo da nota escolar.");
                Console.WriteLine("Desafio: (5) Classes com animais de estimação.");
                Console.WriteLine("         (6) Sair");

                Console.WriteLine("\nDigite o desafio desejado: ");
                opcoes = Convert.ToInt32(Console.ReadLine());
                switch (opcoes)
                {
                    case 1:
                        Console.WriteLine("Lembre-se que as casas decimais são separadas com vígula aqui no C#, tudo bem?");
                        Console.WriteLine("Digite sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());

                        resultado = program.calculoIMC(altura, peso);
                        
                        
                        break;

                    case 2:
                        Console.WriteLine("Lembre-se que as casas decimais são separadas com vígula aqui no C#, tudo bem?\n");

                        Console.WriteLine("Aqui vamos calcular a razão entre seu salário e o salário minimo!");

                        Console.WriteLine("O salário mínimo hoje(16/10/2021) é: R$ 1.192,40\n");
                        Console.WriteLine("Digite seu salário: ");
                        salario = Convert.ToDouble(Console.ReadLine());                        
                        salarioMinimo = 1192.40;

                        resultado = program.razaoSalMinimo(salario,salarioMinimo);
                        resultado = Math.Round(resultado, 2);
                        Console.WriteLine("Seu salário equivale à {0} salários mínimos!", resultado);

                        break;

                    case 3:
                        Console.WriteLine("Lembre-se que as casas decimais são separadas com vígula aqui no C#, tudo bem?\n");

                        Console.WriteLine("Aqui vamos calcular o Volume de uma esfera, através do raio informado por você!");

                        Console.WriteLine("Digite o Raio desejado: ");
                        raio = Convert.ToDouble(Console.ReadLine());

                        resultado = program.calculoVolume(raio);
                        resultado = Math.Round(resultado, 2);
                        Console.WriteLine("O volume da sua esfera é aproximadamente {0}m³!", resultado);

                        break;

                    case 4:
                        Console.WriteLine("Lembre-se que as casas decimais são separadas com vígula aqui no C#, tudo bem?\n");

                        Console.WriteLine("Vamos calcular sua média aritmética de suas notas escolares:");

                        Console.WriteLine("Digite a nota da sua P1: ");
                        p1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a nota da sua P2: ");
                        p2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a nota da sua P3: ");
                        p3 = Convert.ToDouble(Console.ReadLine());

                        media = program.mediaProvas(p1, p2, p3);
                        media = Math.Round(media, 2);                        

                        if (media >= 7)
                        {
                            break;
                        }
                        notaExame = Convert.ToDouble(Console.ReadLine());
                        mediaExame = program.mediaExame(media, notaExame);
                        mediaExame = Math.Round(mediaExame, 2);                        

                        break;

                    case 5:
                        Console.WriteLine("Vamos calcular a quantidade de tipos dos animais inseridos:");
                        int contGato = 0;
                        int contCach = 0;
                        int contPex = 0;

                       for (int i = 0; i < 5; i++) {
                            
                            Console.WriteLine("\nDigite o nome do seu animal de estimação:");
                            nome = Console.ReadLine().Trim();

                            Console.WriteLine("Digite o tipo do seu animal de estimação:");
                            tipo = Console.ReadLine().Trim().ToLower();


                            Estimacao animal = new Estimacao(nome, tipo);


                            Console.WriteLine("\nO nome do seu {1} é: {0}.", animal.getNome(), animal.getTipo());

                            if (tipo == "cachorro")
                            {
                                contCach++;
                            }
                            else if (tipo == "gato")
                            {
                                contGato++;
                            }
                            else
                            {
                                contPex++;
                            }

                       }
                        Console.WriteLine("\nO número de Cachorro é: {0} ", contCach);
                        Console.WriteLine("O número de Gato é: {0} ", contGato);
                        Console.WriteLine("O número de Peixe é: {0} ", contPex);

                        break;

                    case 6:
                        validacao = false;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida. Selecione uma opção válida");
                        Console.WriteLine("Aperte 'Enter' para retornar!");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }
                Console.WriteLine("\nAperte 'Enter' para retornar ao Menu");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);

                                              
        }
        public double calculoIMC(double altura, double peso)
        {
            double resultado = (peso / (altura * altura));            
            
            if (resultado < 20)
            {
                resultado = Math.Round(resultado, 2);
                Console.WriteLine("O resultado do seu IMC é {0}!", resultado);
                Console.WriteLine("Abaixo do peso.");

            }
            else if (resultado >= 20 && resultado < 25)
            {
                resultado = Math.Round(resultado, 2);
                Console.WriteLine("O resultado do seu IMC é {0}!", resultado);
                Console.WriteLine("Peso ideal.");
            }
            else if (resultado >= 25)
            {
                resultado = Math.Round(resultado, 2);
                Console.WriteLine("O resultado do seu IMC é {0}!", resultado);
                Console.WriteLine("Acima do peso");
            }
            return (resultado);
        }       

        public double razaoSalMinimo(double salario, double salarioMinimo)
        {
            return salario / salarioMinimo;
        }

        public double calculoVolume(double raio)

        {
            // Considere π = 3,14
            return (4 * 3.14 * (raio * raio * raio))/3;
        }
        public double mediaProvas(double p1, double p2, double p3)
        {
            double media = (p1 + p2 + p3) / 3;
            if (media >= 7)
            {
                Console.WriteLine("Sua média foi: {0}. Parabéns você foi APROVADO!", media);
                return (media);

            }
            else
            {
                Console.WriteLine("Sua média foi: {0}. Você não atingiu a nota mínima para aprovação direta. \nInsira a sua nota de Exame: ", media);


            }
            return (media);
        }
        public double mediaExame(double media, double notaExame)
        {
            double mediaExame = (media + notaExame) / 2;
            if (mediaExame >= 5)
            {
                Console.WriteLine("Sua média após o exame foi: {0}. Parabéns você foi APROVADO em exame!", mediaExame);
            }
            else
            {
                Console.WriteLine("Sua média após o exame foi: {0}. Infelizmente você foi Reprovado!", mediaExame);
            }
            return(mediaExame);
        }
    }

}






