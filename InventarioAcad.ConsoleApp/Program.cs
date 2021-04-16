using System;

namespace InventarioAcad

{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            MenuInicial();

            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Clear();

                DateTime[] data = new DateTime[300];
                string[] nomePro = new string[300];
                string[] fabricantePro = new string[300];
                int countId = 0;
                double[] precoProduto = new double[300];
                int[] serieProduto = new int[300];

                Console.Clear();

                while (true)
                {
                    Console.Clear();

                    int opEquip;
                    MenuEquipamentos();

                    opEquip = Convert.ToInt32(Console.ReadLine());

                    if (opEquip == 1)
                    {
                        Console.Clear();
                        OpcoesAdd(data, nomePro, fabricantePro, countId, precoProduto, serieProduto);
                        countId++;
                    }


                    if (opEquip == 2)

                    {
                        Console.Clear();

                        Console.WriteLine("Digite o ID do produto para editar: ");
                        int serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < countId; i++)
                        {
                            if (serieProduto[i] == serieBusca)
                            {
                                OpcoesEditar(data, nomePro, fabricantePro, countId, precoProduto, serieProduto, i);
                            }
                        }
                    }
                    if (opEquip == 3)
                    {
                        Console.Clear();

                        Console.WriteLine("Digite o ID para editar: ");
                        int serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < countId; i++)

                        {
                            if (serieProduto[i] == serieBusca)
                            {
                                serieProduto[i] = 0;
                                nomePro[i] = "";
                                fabricantePro[i] = "";
                                precoProduto[i] = 0;
                                data[i] = Convert.ToDateTime("00,00,0000");
                            }
                        }
                    }

                    if (opEquip == 4)

                    {
                        for (int i = 0; i < countId; i++)
                        {
                            Console.WriteLine($"ID:{serieProduto[i]} nome do produto: {nomePro[i]}" +
                                $" fabricante do produto: {fabricantePro[i]} preço do produto: {precoProduto[i]} data de fabri: {data[i]}");
                        }
                        Console.ReadLine();
                    }

                    else if (opEquip == 5)

                    {
                        Console.WriteLine("Até mais :)");
                        Environment.Exit(1);
                    }

                }
            }

            if (opcao == 2)

            {
                Console.Clear();

                DateTime[] data = new DateTime[300];
                string[] nomeChamado = new string[300];
                string[] descricaoChamado = new string[100];
                string[] equipamentosChamado = new string[300];
                int contId = 0;
                Console.Clear();

                while (true)

                {
                    Console.Clear();

                    int opChamado;
                    MenuChamados();
                    opChamado = Convert.ToInt32(Console.ReadLine());

                    if (opChamado == 1)

                    {
                        Console.Clear();
                        OpcoesAddChamado(data, nomeChamado, descricaoChamado, equipamentosChamado, contId);
                        contId++;

                    }

                    if (opChamado == 2)

                    {
                        Console.Clear();

                        Console.WriteLine("Digite a titulo do chamado para editar: ");
                        string titulo = Console.ReadLine();

                        for (int i = 0; i < contId; i++)

                        {
                            if (nomeChamado[i] == titulo)
                            {
                                Console.Clear();
                                OpcoesEditChamado(data, nomeChamado, descricaoChamado, equipamentosChamado, contId, i);
                            }
                        }

                    }

                    if (opChamado == 3)

                    {
                        Console.Clear();

                        Console.WriteLine("Insira o titulo para deletar: ");
                        string tituloDel = Console.ReadLine();

                        for (int i = 0; i < contId; i++)

                        {
                            if (nomeChamado[i] == tituloDel)
                            {
                                nomeChamado[i] = "";
                                descricaoChamado[i] = "";
                                equipamentosChamado[i] = "";
                                data[i] = Convert.ToDateTime("00,00,0000");
                            }
                        }

                    }
                    if (opChamado == 4)
                    {
                        for (int i = 0; i < contId; i++)
                        {
                            string diasDifere = (DateTime.Now - data[i]).ToString("dd");
                            Console.WriteLine($"Título do chamado:{nomeChamado[i]} descrição do chamado: {descricaoChamado[i]} equipamento: {equipamentosChamado[i]} dias em aberto: {diasDifere}");
                        }
                        Console.ReadLine();
                    }

                    else if (opChamado == 5)

                    {
                        Console.WriteLine("Até mais :)");
                        Environment.Exit(1);
                    }
                }
            }
            if (opcao == 3)
            {
                Console.WriteLine("Até mais :)");
                Environment.Exit(1);
            }
        }

        private static void OpcoesEditChamado(DateTime[] data, string[] nomeChamado, string[] descricaoChamado, string[] equipamentosChamado, int contadorId, int i)
        {
            Console.WriteLine("Título do chamado: ");
            nomeChamado[i] = Console.ReadLine();
            Console.WriteLine("Descricao do produto: ");
            descricaoChamado[i] = Console.ReadLine();
            Console.WriteLine("Equipamento: ");
            equipamentosChamado[i] = Console.ReadLine();
            Console.WriteLine("Data (DD/MM/AAAA): ");
            data[contadorId] = Convert.ToDateTime(Console.ReadLine());
        }

        private static void OpcoesAddChamado(DateTime[] data, string[] nomeChamado, string[] descricaoChamado, string[] equipamentosChamado, int contadorId)
        {
            Console.WriteLine("Título do chamado: ");
            nomeChamado[contadorId] = Console.ReadLine();
            Console.WriteLine("Descricao do produto: ");
            descricaoChamado[contadorId] = Console.ReadLine();
            Console.WriteLine("Equipamento: ");
            equipamentosChamado[contadorId] = Console.ReadLine();
            Console.WriteLine("Data (DD/MM/AAAA): ");
            data[contadorId] = Convert.ToDateTime(Console.ReadLine());
        }

        private static void OpcoesAdd(DateTime[] data, string[] nomePro, string[] fabricantePro, int countId, double[] precoProduto, int[] serieProduto)
        {
            Console.WriteLine("Número de Série: ");
            serieProduto[countId] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome do Produto: ");
            nomePro[countId] = Console.ReadLine();
            Console.WriteLine("Fabricante do produto: ");
            fabricantePro[countId] = Console.ReadLine();
            Console.WriteLine("Preço do produto: ");
            precoProduto[countId] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Data (DD/MM/AAAA):");
            data[countId] = Convert.ToDateTime(Console.ReadLine());
        }

        private static void OpcoesEditar(DateTime[] data, string[] nomePro, string[] fabricantePro, int countId, double[] precoProduto, int[] serieProduto, int i)
        {
            Console.WriteLine("Número de série: ");
            serieProduto[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome do produto: ");
            nomePro[i] = Console.ReadLine();
            Console.WriteLine("Fabricante do produto: ");
            fabricantePro[i] = Console.ReadLine();
            Console.WriteLine("Preço do Produto: ");
            precoProduto[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Data (DD/MM/AAAA):");
            data[countId] = Convert.ToDateTime(Console.ReadLine());
        }

        private static void MenuChamados()
        {
            Console.WriteLine("Digite 1 para add");
            Console.WriteLine("Digite 2 para editar");
            Console.WriteLine("Digite 3 para deletar");
            Console.WriteLine("Digite 4 para visualizar");
            Console.WriteLine("Digite 5 para sair");
        }

        private static void MenuEquipamentos()
        {
            Console.WriteLine("Digite 1 para add");
            Console.WriteLine("Digite 2 para editar");
            Console.WriteLine("Digite 3 para deletar");
            Console.WriteLine("Digite 4 para visualizar");
            Console.WriteLine("Digite 5 para sair");
        }

        private static void MenuInicial()
        {
            Console.WriteLine("Digite 1 para equipamentos");
            Console.WriteLine("Digite 2 para chamados");
            Console.WriteLine("Digite 3 para sair");
        }
    }
}