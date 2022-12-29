namespace ShapesBTasks
{
    public static class Tasks
    {        
        public static void Task1(int a)
        {
            int area = 0;

            area = a * a;

            Console.WriteLine($"S = {area}");
        }

        public static void Task2(int r)
        {
            double circumference = 0.0, area = 0.0, pi = 3.14;

            circumference = 2 * pi * r;
            area = pi * r * r;
            Console.WriteLine($"L = {Math.Round(circumference, 2)}, S = {Math.Round(area, 2)}");
        }

        public static void Task3(int a, int b, int c)
        {
            int volume = 0, surfaceArea = 0;

            volume = a * b * c;
            surfaceArea = 2 * (a * b + b * c + a * c);

            Console.WriteLine($"V = {volume}, S = {surfaceArea}");
        }
    }
}
