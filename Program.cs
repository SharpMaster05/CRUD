using CRUD.ViewModels;

UserListViewModel users = new();
bool isEnd = false;
string command;

while (!isEnd)
{
    Console.Write("\n1) Add \n2) Get all \n3) Edit \n4) Delete \n5) Exit \n\nEnter Command => ");
    command = Console.ReadLine();
    Console.WriteLine();
    
    switch (command.ToLower())
    {
        case "add":
            users.AddUser();
            Console.WriteLine();
        break;
        case "get all":
            users.GetAll();    
            Console.WriteLine();    
        break;  
        case "edit":
            users.EditUser();
            Console.WriteLine();
        break;
        case "delete":
            users.DeleteUser(); 
            Console.WriteLine();
        break;
        case "exit": 
            isEnd = true;
        break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Unknown command");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
        break;
    }
}


