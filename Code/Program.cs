string[] generateMassive(string message)
{
    System.Console.WriteLine(message);
    string[] result = new string[10];
    for(int i = 0; i < 10; i++){
        string value = Console.ReadLine();
        if(value == "stop"){
            return result;
        }
        result[i] = value;
    }
    return result;
}

string[] checkMassive(string[] massive){
    string[] result = new string[massive.Length];
    int count = 0;
    for(int i = 0; i < 10; i++){
        if(massive[i] != null){
            if(massive[i].Length <= 3){
                result[count] = massive[i];
                count++;
            }
        }
    }
    return result;
}

void printMassive(string [] collection){
    Console.WriteLine("================================================");
    Console.WriteLine("Массив из слов, в которых меньше или 3 символа: ");
    foreach (var item in collection)
    {
        if(item != null){
            Console.WriteLine(item);
        }
    }
}

printMassive(checkMassive(generateMassive("Вводите по одному слову, если слов достаточно просто напишите stop. Максимум 10 слов:" )));