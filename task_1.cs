using System;

class Employee
{
    int empCode;
    string name, designation;
    double basicPay, hra, da, totalPay;

    public Employee(int empCode, string name, string designation, double basicPay)
    {
        this.empCode = empCode;
        this.name = name;
        this.designation = designation;
        this.basicPay = basicPay;
    }

    public void CalculatePay()
    {
        hra = 0.10 * basicPay;
        da = 0.45 * basicPay; 
        totalPay = basicPay + hra + da;
    }

    public void Display()
    {
        Console.WriteLine($"Code: {empCode}, Name: {name}, Designation: {designation}");
        Console.WriteLine($"Basic Pay: {basicPay}, HRA: {hra}, DA: {da}, Total Pay: {totalPay}\n");
    }
}

class task_1
{
    static void Main()
    {
        Employee e1 = new Employee(101, "Rutvik", "Manager", 50000);
        Employee e2 = new Employee(102, "Kartik", "Developer", 40000);
        Employee e3 = new Employee(103, "Ankit", "Clerk", 30000);

        e1.CalculatePay();
        e2.CalculatePay();
        e3.CalculatePay();

        e1.Display();
        e2.Display();
        e3.Display();
    }
}
