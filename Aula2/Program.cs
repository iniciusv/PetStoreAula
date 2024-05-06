using Domain;
using Infra;
using System;
using System.Collections.Generic;
using Infra;

namespace PetStoreApp;
class Program
{
	static void Main(string[] args)
	{
		using (var context = new PetStoreContext())
		{
			context.Database.EnsureCreated();

			Console.WriteLine("Selecione a entidade com a qual deseja trabalhar:");
			Console.WriteLine("1 - Customer");
			Console.WriteLine("2 - Pet"); // Exemplo, assumindo que você tenha uma entidade Pet
			Console.WriteLine("Escolha uma opção:");
			string entityChoice = Console.ReadLine();

			Type entityType = null;

			switch (entityChoice)
			{
				case "1":
					entityType = typeof(Customer);
					break;
				case "2":
					entityType = typeof(Pet); // Assumindo Pet
					break;
				default:
					Console.WriteLine("Opção inválida.");
					return;
			}

			var repositoryType = typeof(Repository<>).MakeGenericType(entityType);
			dynamic repository = Activator.CreateInstance(repositoryType, context);

			bool running = true;
			while (running)
			{
				Console.WriteLine("\nMenu de Opções:");
				Console.WriteLine("1 - Listar todos");
				Console.WriteLine("2 - Inserir novo");
				Console.WriteLine("3 - Editar");
				Console.WriteLine("4 - Deletar");
				Console.WriteLine("0 - Sair");
				Console.Write("Digite uma opção: ");
				string option = Console.ReadLine();

				switch (option)
				{
					case "1":
						ListAll(repository);
						break;
					case "2":
						AddEntity(repository);
						break;
					case "3":
						EditEntity(repository);
						break;
					case "4":
						DeleteEntity(repository);
						break;
					case "0":
						running = false;
						break;
					default:
						Console.WriteLine("Opção inválida, tente novamente.");
						break;
				}
			}
		}
		Console.WriteLine("Programa encerrado.");
	}

	static void ListAll(dynamic repository)
	{
		var entities = repository.GetAll();
		Console.WriteLine("\nLista de Entidades:");
		foreach (var entity in entities)
		{
			Console.WriteLine(entity);
		}
	}

	static void AddEntity(dynamic repository)
	{
		// Cada tipo de entidade pode precisar de manipulação específica aqui
		Console.WriteLine("Inserção de entidades genéricas não implementada.");
	}

	static void EditEntity(dynamic repository)
	{
		// Cada tipo de entidade pode precisar de manipulação específica aqui
		Console.WriteLine("Edição de entidades genéricas não implementada.");
	}

	static void DeleteEntity(dynamic repository)
	{
		Console.Write("Digite o ID da entidade para deletar: ");
		int id = int.Parse(Console.ReadLine());
		var entity = repository.GetById(id);
		if (entity != null)
		{
			repository.Delete(entity);
			Console.WriteLine("Entidade deletada com sucesso.");
		}
		else
		{
			Console.WriteLine("Entidade não encontrada.");
		}
	}
}
