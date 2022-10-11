using ProductCompany;
using System;

namespace ProductCompanyConsole
{
    class ProductManagerMenu
    {
		private ProductManagerCategoryCommand command = new ProductManagerCategoryCommand();
		public void runMenu()
		{
			showMenuOption();
		}


		private void showMenuOption()
		{
			char userInput = ' ';
			while (userInput != '0')
			{
				Console.Clear();
				Console.WriteLine("Welcome to the Product Company\n");
				Console.WriteLine("Please select an option:\n");
				Console.WriteLine("1) Work with categories");
				Console.WriteLine("2) Work with products");
				Console.WriteLine("0) Exit");
				Console.Write("Your choice : ");

				userInput = Console.ReadKey().KeyChar;
				selectShowMenuOption(userInput);
			}
		}

		private void selectShowMenuOption(char userInput)
		{
			switch (userInput)
			{
				case '1':
					showCategoriesMenu();
					break;
				case '2':
					showProductsMenu();
					break;
				case '0':
					break;
				default:
					printDefaultSwitchStringMenu();
					break;
			}
		}

        private void showProductsMenu()
        {
			char userInput = ' ';
			while (userInput != '0')
			{
				Console.Clear();
				command.SelectCategoryCommand();
				Console.WriteLine();
				Console.WriteLine("1) Add a product");
				Console.WriteLine("2) Change the price");
				Console.WriteLine("3) Block the product");
				Console.WriteLine("4) Search (not yet available)");
				Console.WriteLine("5) Sort within a column (not yet available)");
				Console.WriteLine("0) Exit");
				Console.Write("Your choice : ");

				userInput = Console.ReadKey().KeyChar;
				selectProductsMenuOption(userInput);
			}
		}

        private void selectProductsMenuOption(char userInput)
        {
			switch (userInput)
			{
				case '1':
					//AddProductCommand();
					break;
				case '2':
					//ChangePriceCommand();
					break;
				case '3':
					//BlockProductCommand();
					break;
				case '4':
					//SearchCommand();
					break;
				case '5':
					//SortCommand();
					break;
				case '0':
					break;
				default:
					printDefaultSwitchStringMenu();
					break;
			}
		}

        private void showCategoriesMenu()
        {
			command.PrintAllCategoriesCommand();
			char userInput = ' ';
			while (userInput != '0')
			{
				Console.Clear();
				Console.WriteLine("1) Create category");
				Console.WriteLine("2) Edit category");
				Console.WriteLine("3) Delete category");
				Console.WriteLine("0) Exit");
				Console.Write("Your choice : ");

				userInput = Console.ReadKey().KeyChar;
				selectCategoriesMenuOption(userInput);
			}
		}

        private void selectCategoriesMenuOption(char userInput)
        {
			switch (userInput)
			{
				case '1':
					CreateCategoryMenu();					
					break;
				case '2':
					EditCategoryMenu();
					break;
				case '3':
					DeleteCategoryMenu();					
					break;
				case '0':
					break;
				default:
					printDefaultSwitchStringMenu();
					break;
			}
		}

        private void DeleteCategoryMenu()
        {
			int? сategoryId = null;
			while (!(сategoryId is int)) сategoryId = TrySelectCategoryByIDMenu();

			command.DeleteCategoryCommand((int)сategoryId);
		}

		private void CreateCategoryMenu()
        {
			Console.Clear();
			Console.WriteLine("Enter the name of the category : ");
			string categoryName = Console.ReadLine();
			Console.WriteLine("Write a short description of the category : ");
			string description = Console.ReadLine();

			command.CreateCategoryCommand(categoryName, description);
		}

		private void EditCategoryMenu()
        {
			int? сategoryId=null;
			while(!(сategoryId is int)) сategoryId = TrySelectCategoryByIDMenu();

			Console.Clear();
			Console.WriteLine("Enter a new category name : ");
			string categoryName = Console.ReadLine();
			Console.WriteLine("Write a short description of the category : ");
			string description = Console.ReadLine();

			command.EditCategoryCommand((int)сategoryId, categoryName, description);
		}

		private int? TrySelectCategoryByIDMenu()
        {
			Console.Clear();
			command.PrintAllCategoriesCommand();

			int categoryId;

			Console.Write("\nSelect the category id : ");

			bool success = int.TryParse(Console.ReadLine(), out categoryId);
			return success ? (int?)categoryId : (int?)null;
		}


		private void printDefaultSwitchStringMenu()
		{
			Console.WriteLine("\nWrong command selected");
		}
	}
}
