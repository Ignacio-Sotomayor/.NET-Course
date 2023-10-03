string[] array = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string obj in array) {
    if (obj.StartsWith('B') ){
        Console.WriteLine(obj);
    }
}