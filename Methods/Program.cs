using System.Collections;
using System.Drawing;
using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"
Выбирите коллекцию методов:
1. Array
2. Array List
3. HashTable
4. Stack
5. List
6. Queue
7. SortList
8. Dictionary
9. Set
10. Конец работы программы");
                string menu1=Console.ReadLine();
                Console.WriteLine();
                if (menu1 == "1")
                {
                    int[] myInt = new int[5] { 1, 2, 3, 4, 5 };
                    while (true)
                    {
                        int numer;
                        for (int i = 0; i < myInt.Length; i++)
                        {
                            Console.WriteLine(myInt[i]);
                        }
                        Console.WriteLine(@"
1) Общее число элементов
2) Число измерений 
3) Бинарный поиск элемента
4) Сортировка
5) Возвращаем строку
6) Значение по указанной позиции
7) Поиск заданного объекта внутри всего одномерного массива
8) Изменяем количество элементов в массиве до указанной величины
9) Изменяем порядок элементов во всем одномерном массиве Array на обратный
10)Очистка Array
11)Выход
");
                        string num = Console.ReadLine();
                        if (num == "1")
                        {
                            Console.WriteLine(myInt.Length);
                            Console.ReadKey();
                        }
                        else if (num == "2")
                        {
                            Console.WriteLine(myInt.Rank);
                            Console.ReadKey();
                        }
                        else if (num == "3")
                        {
                            numer = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Array.BinarySearch(myInt, numer));
                            Console.ReadKey();
                        }
                        else if (num == "4")
                        {
                            Array.Sort(myInt);
                            Console.ReadKey();
                        }
                        else if (num == "5")
                        {
                            Console.WriteLine(myInt.ToString);
                            Console.ReadKey();
                        }
                        else if (num == "6")
                        {
                            numer = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(myInt.GetValue(numer));
                            Console.ReadKey();
                        }
                        else if (num == "7")
                        {
                            numer = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Array.IndexOf(myInt, numer));
                            Console.ReadKey();
                        }
                        else if (num == "8")
                        {
                            numer = Convert.ToInt32(Console.ReadLine());
                            Array.Resize<int>(ref myInt, numer);
                            Console.ReadKey();
                        }
                        else if (num == "9")
                        {
                            Array.Reverse(myInt);
                            Console.ReadKey();
                        }
                        else if (num == "10")
                        {
                            Array.Clear(myInt);
                        }
                        else if (num == "11")
                        {
                            Console.ReadKey(true);
                            break;
                        }
                        Console.Clear();
                    }
                }
                else if (menu1 == "2")
                {
                    ArrayList myInt = new ArrayList() ;
                    while (true)
                    {
                        for (int d = 0; d< myInt.Count; d++)
                            {
                            Console.WriteLine(myInt[d]);
                            }
                        Console.WriteLine(@"
1) Добавление элемента
2) Бинарный поиск
3) Часть Коллекции
4) Индекс первого вхождения элемента
5) Только для чтения 
6) Удаление части коллекции
7) Revers
8) Sort
9) Колличество элементов
10) Clear
11) Выход
");
                        int count; int numer;
                        string num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                num = Console.ReadLine();
                                myInt.Add(num);
                                Console.ReadKey();
                                break;
                            case "2":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.BinarySearch(num));
                                Console.ReadKey();
                                break;
                            case "3":
                                numer = Convert.ToInt32(Console.ReadLine());
                                count = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(myInt.GetRange(numer, count));
                                Console.ReadKey();
                                break;
                            case "4":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.IndexOf(num));
                                Console.ReadKey();
                                break;
                            case "5":
                                Console.WriteLine(ArrayList.ReadOnly(myInt));
                                Console.ReadKey();
                                break;
                            case "6":
                                numer = Convert.ToInt32(Console.ReadLine());
                                count = Convert.ToInt32(Console.ReadLine());
                                myInt.RemoveRange(numer, count);
                                Console.ReadKey();
                                break;
                            case "7":
                                myInt.Reverse();
                                Console.ReadKey();
                                break;
                            case "8":
                                myInt.Sort();
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(myInt.Count);
                                Console.ReadKey();
                                break;
                            case "10":
                                myInt.Clear();
                                break;
                            default:
                                break;
                        }
                        Console.Clear();
                        if (num == "11") { break; }
                    }
                    



                }
                else if (menu1 == "3")
                {

                    Hashtable hashtable = new Hashtable();
                    while (true)
                    {
                        foreach (DictionaryEntry pum in hashtable)
                        {
                            Console.WriteLine("{0}   {1}",pum.Key,pum.Value);
                        }
                        Console.WriteLine(@"
1) Добавить key and value
2) Проверка, содержится ли ключ в hachtable
3) Проверка, содержится ли значение в hachtable
4) GetEnumerator
5) GetHash
6) GetType
7) Удаление элементов
8) Десериализация
9) Возвращение синхронизированной оболочки
10) Очистка
11) Выход
");
                        int count; int numer;
                        string num = Console.ReadLine();


                        switch (num)
                        {
                            case "1":
                                numer = Convert.ToInt32(Console.ReadLine());
                                count = Convert.ToInt32(Console.ReadLine());
                                hashtable.Add(numer, count);
                                Console.ReadKey();
                                break;
                            case "2":
                                numer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(hashtable.Contains(numer));
                                Console.ReadKey();
                                break;
                            case "3":
                                count = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(hashtable.ContainsValue(count));
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.WriteLine(hashtable.GetEnumerator());
                                Console.ReadKey();
                                break;
                            case "5":
                                numer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(numer.GetHashCode());
                                Console.ReadKey();
                                break;
                            case "6":
                                numer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(numer.GetType);
                                Console.ReadKey();
                                break;
                            case "7":
                                numer = Convert.ToInt32(Console.ReadLine());
                                hashtable.Remove(numer);
                                Console.ReadKey();
                                break;
                            case "8":
                                Console.WriteLine(hashtable.OnDeserialization);
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(hashtable.IsSynchronized);
                                Console.ReadKey();
                                break;
                            case "10":
                                hashtable.Clear();
                                break;
                            default:
                                break;
                        }


                        if (num == "11") { break; }
                    }



                }
                else if (menu1 == "4")
                {
                    Stack myInt = new Stack();
                    Stack myStack = new Stack();
                    while (true)
                    {
                        int numer, count;
                        foreach (string i in myInt)
                            Console.WriteLine(i);
                        Console.WriteLine(@"
1) Очистка
2) Входит ли элемент в стэк
3) Возвращение объекта без его удаление
4) Возвращение и удаление объекта
5) Добавить элемент
6) Скобки
7) Выход
");

                        string num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                myInt.Clear();
                                Console.ReadKey();
                                break;
                            case "2":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Contains(num));
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.WriteLine(myInt.Peek());
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.WriteLine(myInt.Pop());
                                Console.ReadKey();
                                break;
                            case "5":
                                num = Console.ReadLine();
                                myInt.Push(num);
                                Console.ReadKey();
                                break;
                            case "6":
                                object b;
                                int value = 0;
                                num = Console.ReadLine();
                                foreach (var s in num)
                                {
                                    if (s == '(' || s == '{' || s == '[')
                                    {
                                        myStack.Push(s);
                                    }
                                    else if (myStack.Count != 0)
                                    {
                                        b = myStack.Peek();
                                        if (s == ')' && b is '(')
                                        {
                                            myStack.Pop();
                                        }
                                        if (s == ']' && b is '[')
                                        {
                                            myStack.Pop();
                                        }
                                        if (s == '}' && b is '{')
                                        {
                                            myStack.Pop();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Нет");
                                        Console.ReadKey();
                                        value++;
                                        break;
                                    }
                                }
                                if (value == 0 && myStack.Count == 0)
                                {
                                    Console.WriteLine("Да");
                                    Console.ReadKey();
                                }
                                else if (value == 0 && myStack.Count != 0)
                                {
                                    Console.WriteLine("Нет");
                                    Console.ReadKey();
                                }
                                break;

                            case "7":
                                break;
                        }
                        Console.Clear();
                        if (num == "7")
                        {
                            break;
                        }
                    }
                }
                else if (menu1 == "5")
                {
                    List<string> myInt = new List<string>();
                    while (true)
                    {
                        int numer, count;
                        for (int i = 0; i < myInt.Count; i++)
                        {
                            Console.WriteLine(myInt[i]);
                        }

                        Console.WriteLine(@"
1) Очистка
2) Входит ли значение в Лист 
3) Бинарный поиск
4) Устонавливаем ёмкость такой какой бы она была, если бы элементы уже были
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                        string num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                myInt.Clear();
                                Console.ReadKey();
                                break;
                            case "2":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Contains(num));
                                Console.ReadKey();
                                break;
                            case "3":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.BinarySearch(num));
                                Console.ReadKey();
                                break;
                            case "4":
                                myInt.TrimExcess();
                                Console.ReadKey();
                                break;
                            case "5":
                                num = Console.ReadLine();
                                myInt.Add(num);
                                Console.ReadKey();
                                break;
                            case "6":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Equals(num));
                                Console.ReadKey();
                                break;
                            case "7":
                                Console.WriteLine(myInt.GetEnumerator());
                                Console.ReadKey();
                                break;
                            case "8":
                                Console.WriteLine(myInt.GetHashCode());
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(myInt.GetType());
                                Console.ReadKey();
                                break;
                            case "10":
                                Console.WriteLine(myInt.ToString());
                                Console.ReadKey();
                                break;

                            case "11":
                                break;
                        }
                        Console.Clear();
                        if (num == "11")
                        {
                            break;
                        }
                    }
                }
                else if (menu1 == "6")
                {
                    Queue myInt = new Queue();
                    while (true)
                    {
                        int numer, count;

                        foreach(string bob in myInt)
                        {
                            Console.WriteLine(bob);
                        }

                        Console.WriteLine(@"
1) Очистка
2) Входит ли элемент в очередь 
3) Возвращение объекта без его удаление
4) Возвращение и удаление объекта
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                        string num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                myInt.Clear();
                                Console.ReadKey();
                                break;
                            case "2":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Contains(num));
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.WriteLine(myInt.Peek());
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.WriteLine(myInt.Dequeue());
                                Console.ReadKey();
                                break;
                            case "5":
                                num = Console.ReadLine();
                                myInt.Enqueue(num);
                                Console.ReadKey();
                                break;
                            case "6":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Equals(num));
                                Console.ReadKey();
                                break;
                            case "7":
                                Console.WriteLine(myInt.GetEnumerator());
                                Console.ReadKey();
                                break;
                            case "8":
                                Console.WriteLine(myInt.GetHashCode());
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(myInt.GetType());
                                Console.ReadKey();
                                break;
                            case "10":
                                Console.WriteLine(myInt.ToString());
                                Console.ReadKey();
                                break;

                            case "11":
                                break;
                        }
                        Console.Clear();
                        if (num == "11")
                        {
                            break;
                        }
                    }
                }
                else if (menu1 == "7")
                {
                    SortedList myInt = new SortedList();
                    while (true)
                    {
                        int numer, count;

                        for (int i = 0; i < myInt.Count; i++)
                        {
                            Console.WriteLine(myInt[i]);
                        }
                        Console.WriteLine(@"
1) Очистка
2) Входит ли значение в Лист 
3) Удаление по значению
4) Получение Type
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                        string num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                myInt.Clear();
                                Console.ReadKey();
                                break;
                            case "2":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Contains(num));
                                Console.ReadKey();
                                break;
                            case "3":
                                num = Console.ReadLine();
                                myInt.Remove(num);
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.WriteLine(myInt.GetType());
                                Console.ReadKey();
                                break;
                            case "5":
                                num = Console.ReadLine();
                                myInt.Add(num, num);
                                Console.ReadKey();
                                break;
                            case "6":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Equals(num));
                                Console.ReadKey();
                                break;
                            case "7":
                                Console.WriteLine(myInt.GetEnumerator());
                                Console.ReadKey();
                                break;
                            case "8":
                                Console.WriteLine(myInt.GetHashCode());
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(myInt.GetType());
                                Console.ReadKey();
                                break;
                            case "10":
                                Console.WriteLine(myInt.ToString());
                                Console.ReadKey();
                                break;

                            case "11":
                                break;
                        }
                        Console.Clear();
                        if (num == "11")
                        {
                            break;
                        }
                    }
                }
                else if (menu1 == "8")
                {
                    Dictionary<string, string> myInt = new Dictionary<string, string>();
                    while (true)
                    {
                        int numer, count;

                        Console.WriteLine(myInt);
                        foreach(var bob in myInt)
                        {
                            Console.WriteLine("{0}   {1}",bob.Key,bob.Value);
                        }

                        Console.WriteLine(@"
1) Очистка
2) Входит ли ключ в словарь 
3) Входит ли значение в словарь 
4) Устонавливаем ёмкость такой какой бы она была, если бы элементы уже были
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                        string num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                myInt.Clear();
                                Console.ReadKey();
                                break;
                            case "2":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.ContainsKey(num));
                                Console.ReadKey();
                                break;
                            case "3":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.ContainsValue(num));
                                Console.ReadKey();
                                break;
                            case "4":
                                myInt.TrimExcess();
                                Console.ReadKey();
                                break;
                            case "5":
                                num = Console.ReadLine();
                                string tot=Console.ReadLine();
                                myInt.Add(num, tot);
                                Console.ReadKey();
                                break;
                            case "6":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Equals(num));
                                Console.ReadKey();
                                break;
                            case "7":
                                Console.WriteLine(myInt.GetEnumerator());
                                Console.ReadKey();
                                break;
                            case "8":
                                Console.WriteLine(myInt.GetHashCode());
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(myInt.GetType());
                                Console.ReadKey();
                                break;
                            case "10":
                                Console.WriteLine(myInt.ToString());
                                Console.ReadKey();
                                break;

                            case "11":
                                break;
                        }
                        Console.Clear();
                        if (num == "11")
                        {
                            break;
                        }
                    }
                }
                else if (menu1 == "9")
                {
                    SortedSet<string> myInt = new SortedSet<string>();
                    while (true)
                    {
                        int numer, count;

                        foreach(string bob in myInt)
                        {
                            Console.WriteLine(bob);
                        }
                        Console.WriteLine(@"
1) Очистить Set
2) Входит ли значение в Set
3) Удаление по значению
4) Получение Type
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                        string num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                myInt.Clear();
                                Console.ReadKey();
                                break;
                            case "2":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Contains(num));
                                Console.ReadKey();
                                break;
                            case "3":
                                num = Console.ReadLine();
                                myInt.Remove(num);
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.WriteLine(myInt.GetType());
                                Console.ReadKey();
                                break;
                            case "5":
                                num = Console.ReadLine();
                                myInt.Add(num);
                                Console.ReadKey();
                                break;
                            case "6":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.Equals(num));
                                Console.ReadKey();
                                break;
                            case "7":
                                Console.WriteLine(myInt.GetEnumerator());
                                Console.ReadKey();
                                break;
                            case "8":
                                Console.WriteLine(myInt.GetHashCode());
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(myInt.GetType());
                                Console.ReadKey();
                                break;
                            case "10":
                                Console.WriteLine(myInt.ToString());
                                Console.ReadKey();
                                break;

                            case "11":
                                break;
                        }
                        Console.Clear();
                        if (num == "11")
                        {
                            break;
                        }
                    }
                }
                else if (menu1 == "10")
                {
                    break;
                }
            }
        }
    }
}