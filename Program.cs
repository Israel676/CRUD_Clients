using System;
using CRUD_Clients.Models;
using CRUD_Clients.Models;

class Program
{
    static void Main()
    {
        ClientController controller = new ClientController();

        // Example: Display all clients
        //Console.WriteLine("All Clients:");
        //foreach (var client in controller.GetAllClients())
        //{
        //    Console.WriteLine($"{client.ID} - {client.Name}, {client.Number}, {client.Email}");
        }

        // Example: Add a new client
        Console.WriteLine("\nAdding a new client...");
        Client newClient = new Client { Name = "John Doe", Number = "1234567890", Email = "john@example.com" };
        controller.AddClient(newClient);

        // Example: Update a client
        //Console.WriteLine("\nUpdating a client...");
        //Client updatedClient = new Client { ID = 1, Name = "Updated John Doe", Number = "9876543210", //Email = "updatedjohn@example.com" };
        //controller.UpdateClient(updatedClient);

        // Example: Delete a client
        //Console.WriteLine("\nDeleting a client...");
        //int clientIdToDelete = 2;
        //controller.DeleteClient(clientIdToDelete);

    }
}
