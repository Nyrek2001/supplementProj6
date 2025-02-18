class Program
{
    static void Main()
    {
        ShapeContainer container = new ShapeContainer();

        while (true)
        {
            Console.WriteLine("\nOptions: [1] Create Shape, [2] Get Shape, [3] Delete Shape, [4] Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter shape type (cube/sphere/cylinder): ");
                    string type = Console.ReadLine().ToLower();

                    try
                    {
                        if (type == "cube")
                        {
                            Console.Write("Enter side length: ");
                            double side = double.Parse(Console.ReadLine());
                            var cube = new Cube(side);
                            container.Create(cube);
                            Console.WriteLine(cube.Dump());
                        }
                        else if (type == "sphere")
                        {
                            Console.Write("Enter radius: ");
                            double radius = double.Parse(Console.ReadLine());
                            var sphere = new Sphere(radius);
                            container.Create(sphere);
                            Console.WriteLine(sphere.Dump());
                        }
                        else if (type == "cylinder")
                        {
                            Console.Write("Enter radius: ");
                            double radius = double.Parse(Console.ReadLine());
                            Console.Write("Enter height: ");
                            double height = double.Parse(Console.ReadLine());
                            var cylinder = new Cylinder(radius, height);
                            container.Create(cylinder);
                            Console.WriteLine(cylinder.Dump());
                        }
                        else
                        {
                            Console.WriteLine("Invalid shape type.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;

                case "2":
                    Console.Write("Enter index: ");
                    try
                    {
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine(container.Get(index).Dump());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;

                case "3":
                    Console.Write("Enter index to delete: ");
                    try
                    {
                        int index = int.Parse(Console.ReadLine());
                        container.Delete(index);
                        Console.WriteLine("Shape deleted.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
