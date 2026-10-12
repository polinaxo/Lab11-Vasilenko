// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1001;
// bool found = false;

// foreach (int number in recordBooks) {
//     if (number == target) {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// int variant = 2;
// bool isPrime = true;

// if (variant == 1) {
//     isPrime = false;
// } else {
//     for (int divisor = 2; divisor < variant; divisor++) {
//         if (variant % divisor == 0) {
//             isPrime = false;
//             break;
//         }
//     }
// }

// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");


// int[] pointsPerLab = { 8, -1, 10, 9, -1 };
// int sum = 0;
// int count = 0;

// foreach (int points in pointsPerLab) {
//     if (points < 0) {
//         continue;
//     }
//     sum += points;
//     count++;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Сдано работ: {count}");

// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++) {
//     for (int j = i + 1; j < groupIds.Length; j++) {
//         if (groupIds[i] == groupIds[j]) {
//             Console.WriteLine($"Найдены дубликаты {groupIds[i]} и {groupIds[j]}");
//             hasDuplicates = true;
//             break;
//         }
//     }
//     if (hasDuplicates) {
//         break;
//     }
// }

// if (!hasDuplicates) {
//     Console.WriteLine("Все номера уникальны");
// }

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;
// for (int day = 1; day <= days && !found; day++) {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++) {
//         bool isFree = (day == 3 && lesson == 4); 
//         if (isFree) {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }
// if (!found) {
//     Console.WriteLine("Свободных слотов нет");
// }


//самостоятельные задания А и Б
// int[] array = { 5, 3, 8, 4, 2 };
// int target = 4;
// int index = -1;
// bool found = false; 

// for (int i = 0; i < array.Length; i++) {
//     if (array[i] == target) {
//         index = i;
//         found = true;
//         break;
//     }
// }
// if (found) {
//     Console.WriteLine($"Число {target} найдено по индексу: {index}");
// } else {
//     Console.WriteLine($"Число {target} в массиве не найдено.");
// }


// int number = 17;
// bool isPrime = true;
// if (number < 2) {
//     isPrime = false;
// } else {
//     for (int divisor = 2; divisor < number; divisor++) {
//         if (number % divisor == 0) {
//             isPrime = false;
//             break;  
//         }
//     }
// }
// if (isPrime) {
//     Console.WriteLine($"{number} — простое число.");
// } else {
//     Console.WriteLine($"{number} — составное число.");
// }



// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList(); 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


//вариант 4
// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++) {
//     for (int j = i + 1; j < groupIds.Length; j++) {
//         if (groupIds[i] == groupIds[j]) {
//             Console.WriteLine($"Найдены дубликаты {groupIds[i]} индекс {i} и {groupIds[j]} индекс {j}");
//             hasDuplicates = true;
//             break;
//         }
//     }
//     if (hasDuplicates) {
//         break;
//     }
// }

// if (!hasDuplicates) {
//     Console.WriteLine("Все номера уникальны");
// }

//вариант 8
int[] array1 = { 3, 7, 9, 12 };
int[] array2 = { 5, 8, 9, 20, 30 };
bool found = false;
int commonElement = 0;
for (int i = 0; i < array1.Length && !found; i++) {
    for (int j = 0; j < array2.Length; j++) {
        if (array1[i] == array2[j]) {
            commonElement = array1[i];
            found = true;
            break;
        }
    }
}
if (found) {
    Console.WriteLine($"Найден общий элемент: {commonElement}");
} else {
    Console.WriteLine("Общих элементов нет");
}