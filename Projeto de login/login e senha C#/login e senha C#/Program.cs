using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace login_e_senha_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("Bem vindo ao cadastro do centro pokémon, digite seu nome de usuário: ");

            string login = Console.ReadLine();

            Console.WriteLine("Agora digite a sua senha");
            string senha = "";

            while (true)
            {
                ConsoleKeyInfo digito = Console.ReadKey(true);
                if (digito.Key == ConsoleKey.Enter) 
                    break;
                else
                {
                    senha += digito.KeyChar;
                }
            }
            if (login == "Ashe" && senha == "Pikachu")
            {
                Console.WriteLine("Usuário conectado com sucesso");
                    break;
            }
            else
            {
                Console.WriteLine("Falha na conexão com o servidor, usuário desconhecido");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente");
                Console.ReadKey();
                Console.Clear();
            }
          }
            Console.WriteLine("Pressione qualquer botão para sair");
            Console.ReadKey();
        }
    }
}
