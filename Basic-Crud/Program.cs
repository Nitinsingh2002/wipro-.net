using Basic_Crud;

internal class Program
{
    private static void Main(string[] args)
    {
        //Employee[] emp = new Employee[5];

        //for(int i =0; i < 2; i++)
        //{
        //    Console.WriteLine($"enter details for {i} employee");
        //    Console.WriteLine("Enter EmployeeId:");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter EmployeeName:");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter Dept");
        //    string dpt = Console.ReadLine();
        //    Console.WriteLine("Enter Salary");
        //    decimal sal = Convert.ToDecimal(Console.ReadLine());
        //    emp[i] = new Employee(id, name, dpt, sal);

        //}


        //for(int i =0; i<2; i++)
        //{
        //    Console.WriteLine($" employee id {emp[i].id} employee name is {emp[i].name}");
        //}


        Console.WriteLine("slect the option between 1 to 4 ");
        Console.WriteLine("enter 1 for adding user");
        Console.WriteLine("enter 2 for display");

        int number;

        while(!int.TryParse(Console.ReadLine(),out number))
        {
            Console.WriteLine("ENter valid number between 1 to 4");
        }

        EmployeeCurd cd = new EmployeeCurd();

        if(number == 1)
        {
            Console.WriteLine("Enter EmployeeId:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter EmployeeName:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Dept");
            string dpt = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            decimal sal = Convert.ToDecimal(Console.ReadLine());
            cd.addEmployee(id, name, dpt, sal);
        }
    }
}