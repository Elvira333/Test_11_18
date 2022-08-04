/* Написать программу для операции "произведение массивов". 
Сама операция определяется так, как будто элементы массива - это коэффициенты полинома.
Соответственно, произведение массивов - должно дать новый массив, 
коэффициенты которого соответсвуют нужному полиному.

Например, возьмем полином (x - 1) и полином (x + 2). 
Их можно представить в виде массивов [-1, 1] и [2, 1] соответственно.
Индекс элемента в массиве соответствует степени x при этом коээфициенте, 
т.е. полином (x - 1) можно переписать как (-1 * x^0 + 1 * x^1), 
таким образом соответсвующий этому полиному массив будет иметь вид [-1, 1].

По указанному правилу произведение массивов [-1, 1] и [2, 1] должно быть равно [-2, 1, 1],
т.к. (x - 1) * (x + 2) = (x^2 + x^1 - 2).*/

// Метод нахождения длины результирующего массива
int FindLength(int[] arrayFirst, int[] arraySecond)
{
    int lengthArray;
    lengthArray = arrayFirst.Length + arraySecond.Length - 1;
    return lengthArray;
}

// Метод заполнения нового массива, путем перемножения
int[] MultiplyingArrays(int[] arrayFirst, int[] arraySecond, int[] newArray)
{
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        for (int j = 0; j < arraySecond.Length; j++)
        {
            newArray[i + j] += arrayFirst[i] * arraySecond[j];
        }

    }
    return newArray;
}
// Метод вывода нового массива на консоль
void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();
}

// Тесты программы
// 1 пример
int[] arr1 = { -1, 1, 1 };
int[] arr2 = { 2, 1 };
int[] resultArray1 = new int[FindLength(arr1, arr2)];
resultArray1 = MultiplyingArrays(arr1, arr2, resultArray1);
PrintArray(resultArray1);
int[] answer1 = { -2, 1, 3, 1 };
if (resultArray1.SequenceEqual(answer1) == true)
    Console.WriteLine("Тест пройден");
else
    Console.WriteLine("Тест провален");

// 2 пример
int[] arr3 = { 3, 1, 1, 5, 6 };
int[] arr4 = { 4, 1, -3 };
int[] resultArray2 = new int[FindLength(arr3, arr4)];
resultArray2 = MultiplyingArrays(arr3, arr4, resultArray2);
PrintArray(resultArray2);
int[] answer2 = { 6, 1, 5, 1 };
if (resultArray2.SequenceEqual(answer2) == true)
    Console.WriteLine("Тест пройден");
else
    Console.WriteLine("Тест провален");

// 3 пример
int[] arr5 = { 3, 2 };
int[] arr6 = { 4, 1, 5, -3, 7 };
int[] resultArray3 = new int[FindLength(arr5, arr6)];
resultArray3 = MultiplyingArrays(arr5, arr6, resultArray3);
PrintArray(resultArray3);
int[] answer3 = { 12, 11, 17, 1, 15, 14 };
if (resultArray3.SequenceEqual(answer3) == true)
    Console.WriteLine("Тест пройден");
else
    Console.WriteLine("Тест провален");

// 4 пример
int[] arr7 = { 0, 0 };
int[] arr8 = { 0, 0 };
int[] resultArray4 = new int[FindLength(arr7, arr8)];
resultArray4 = MultiplyingArrays(arr7, arr8, resultArray4);
PrintArray(resultArray4);
int[] answer4 = { 0, 0 };
if (resultArray4.SequenceEqual(answer4) == true)
    Console.WriteLine("Тест пройден");
else
    Console.WriteLine("Тест провален");