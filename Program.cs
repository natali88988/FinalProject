Console.WriteLine($"Введите массив строк через пробел: ");
string[] inputArray = Console.ReadLine().Split(' ').ToArray();
string[] outputArray = new string[inputArray.Length];

void CreateOutputArray(string[] inputArray, string[] outputArray) {
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++) {
    if(inputArray[i].Length <= 3) {
        outputArray[count] = inputArray[i];
        count++;
        }
    }
}

CreateOutputArray(inputArray, outputArray);
Console.WriteLine($"Массив строк, длинна которых меньше или равна 3 символам: ");
for (int i = 0; i < outputArray.Length; i++) Console.Write($"{outputArray[i]} ");