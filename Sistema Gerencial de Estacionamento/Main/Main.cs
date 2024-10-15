using Sistema_Gerencial_de_Estacionamento.Attributes;
using Sistema_Gerencial_de_Estacionamento.Features;

namespace Sistema_Gerencial_de_Estacionamento.Main
{
    internal class Main
    {
        static void Program(string[] args)
        {

            #region Instancições
            StorageEntry aux_r=new StorageEntry();

            #endregion
            int op = 1;

            while (true){
                Console.WriteLine("============================================");
                Console.WriteLine("Sistema de Estacionamento");
                Console.WriteLine("============================================");
                Console.WriteLine("1. Registrar Entrada de Veículo/Moto");
                Console.WriteLine("2. Registrar Saída de Veículo/Moto");
                Console.WriteLine("3. Consultar Vagas Disponíveis");
                Console.WriteLine("4. Deletar Registro");
                Console.WriteLine("5. Ver Histórico de Veículos");
                Console.WriteLine("6. Exibir Tarifas");
                Console.WriteLine("7. Relatórios Gerenciais (Admin)");
                Console.WriteLine("8. Configurações do Sistema (Admin)");
                Console.WriteLine("9. Sair");
                Console.WriteLine("============================================");
                Console.WriteLine("Escolha uma opção:");
                while (!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 8)
                {
                    Console.WriteLine("\nOpção inválida. Digite um digito, sendo de 1 a 8.");
                }
                switch (op)
                {
                    case 1:
                        aux_r.S_Name();
                        aux_r.S_Entry();
                        break;

                    case 2:
                        //implemento de direicionamento ao método
                        break;

                    case 3:
                        //implemento de direicionamento ao método
                        break;

                    case 4:
                        //implemento de direicionamento ao método
                        break;

                    case 5:
                        //implemento de direicionamento ao método
                        break;

                    case 6:
                        //implemento de direicionamento ao método
                        break;

                    case 7:
                        //implemento de direicionamento ao método
                        break;

                    case 8:
                        Console.WriteLine("\nSistema encerrado.");
                        //Encerrar conexão com o db e encerrar todas as reservas de veículos.
                        return;
                }

            }
        }
    }
}
