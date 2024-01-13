using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Clients.Models
{
    public class ClienteRepository
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine("Cliente adicionado com sucesso!");
        }

        public void ListarClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }

            Console.WriteLine("Lista de Clientes:");

            foreach (var c in clientes)
            {
                Console.WriteLine($"ID: {c.Id}, Nome: {c.Nome}, E-mail: {c.Email}, Telefone: {c.Telefone}");
            }
        }

        public Cliente EncontrarClientePorId(int id)
        {
            return clientes.Find(c => c.Id == id);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            Console.Write("Digite o novo Nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Digite o novo E-mail do cliente: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Digite o novo Telefone do cliente: ");
            cliente.Telefone = Console.ReadLine();

            Console.WriteLine("Cliente atualizado com sucesso!");
        }

        public void RemoverCliente(Cliente cliente)
        {
            clientes.Remove(cliente);
            Console.WriteLine("Cliente removido com sucesso!");
        }
    }
}