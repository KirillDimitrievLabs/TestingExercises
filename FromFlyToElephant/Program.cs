class Program
{
	static void Main(string[] args)
	{
        TransformToElephant();
        Console.WriteLine("Муха");

        //... custom application code

        Console.WriteLine("test");
        Console.ReadLine();
    }

	static void TransformToElephant()
	{
        //1)
        //Ломает консольный вывод изза перенаправления вывода
        //if (Console.Out.NewLine != "Слон")
        //{
        //    Console.WriteLine("Слон");
        //    Console.SetOut(new StringWriter() { NewLine = "Слон" });

        //    Main(Array.Empty<string>());
        //}

        //2)
        //не ломает ввод, но unsafe
        //и все мухи превращаются в слонов
       unsafe
        {
            
            ReadOnlySpan<char> elephant = "Слон";
            fixed (char* ptr = "Муха")
            {
                elephant.CopyTo(new Span<char>(ptr, 4));
            }
        }
    }
}