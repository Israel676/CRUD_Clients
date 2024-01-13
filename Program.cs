using CRUD_Clients.Models;

ClienteRepository clienteRepository = new ClienteRepository();

    while (true)
    {
        Console.WriteLine("1 - Adicionar Cliente");
        Console.WriteLine("2 - Listar Clientes");
        Console.WriteLine("3 - Atualizar Cliente");
        Console.WriteLine("4 - Remover Cliente");
        Console.WriteLine("5 - Sair");

        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                AdicionarCliente(clienteRepository);
                break;
            case "2":
                ListarClientes(clienteRepository);
                break;
            case "3":
                AtualizarCliente(clienteRepository);
                break;
            case "4":
                RemoverCliente(clienteRepository);
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }


static void AdicionarCliente(ClienteRepository clienteRepository)
{
    Cliente cliente = new Cliente();

    Console.Write("Digite o ID do cliente: ");
    cliente.Id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o Nome do cliente: ");
    cliente.Nome = Console.ReadLine();

    Console.Write("Digite o E-mail do cliente: ");
    cliente.Email = Console.ReadLine();

    Console.Write("Digite o Telefone do cliente: ");
    cliente.Telefone = Console.ReadLine();

    clienteRepository.AdicionarCliente(cliente);
}

static void ListarClientes(ClienteRepository clienteRepository)
{
    clienteRepository.ListarClientes();
}

static void AtualizarCliente(ClienteRepository clienteRepository)
{
    Console.Write("Digite o ID do cliente que deseja atualizar: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Cliente cliente = clienteRepository.EncontrarClientePorId(id);

    if (cliente == null)
    {
        Console.WriteLine("Cliente não encontrado.");
        return;
    }

    clienteRepository.AtualizarCliente(cliente);
}

static void RemoverCliente(ClienteRepository clienteRepository)
{
    Console.Write("Digite o ID do cliente que deseja remover: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Cliente cliente = clienteRepository.EncontrarClientePorId(id);

    if (cliente == null)
    {
        Console.WriteLine("Cliente não encontrado.");
        return;
    }

    clienteRepository.RemoverCliente(cliente);
}