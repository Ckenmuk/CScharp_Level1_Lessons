namespace Lesson01
{
    internal class Ex01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета");

            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилию: ");
            string fname = Console.ReadLine();

            Console.Write("Возраст: ");
            int age = int.Parse(Console.ReadLine()); // вводим строку, преобразуем строку в число

            Console.Write("Рост в сантиметрах: ");
            int height = int.Parse(Console.ReadLine()); // вводим строку, преобразуем строку в число

            Console.Write("Вес в килограммах: ");
            int weight = int.Parse(Console.ReadLine()); // вводим строку, преобразуем строку в число


            Console.WriteLine(name + " " + fname + ", " + age + " лет, " + "{0:F1}"/* задаем формат*/, height + " см, " + weight + " кг. ");
            Console.WriteLine($"Имя: {name}, фамилия: {fname}, возраст: {age}, рост (см): {height}, вес (кг): {weight}");

            Console.ReadLine();
        }
    }
}