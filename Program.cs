//tring subject = "Программирование";
//
//oreach (char letter in subject) {
//   Console.WriteLine(letter);
//
//onsole.WriteLine($"Всего букв: {subject.Length}");
//nt[] grad = { 4, 5, 3, 5, 4 };
//nt sum = 0;
//
//oreach (int i in grad) {
//   Console.WriteLine(i);
//   sum += i;
//
//ouble cred = (double)sum / grad.Length;
//onsole.WriteLine($"Сумма: {sum}");
//onsole.WriteLine($"Средний балл: {cred}");

//string[] students = { "Аня", "Ярослав", "Вика" };
//int count = 0;
//foreach (string student in students) {
//    Console.WriteLine(student);
//    count++;
//}
//Console.WriteLine($"Всего учеников: {count}");
//
//int[] points = { 10, 20, 15 };
//
//for (int i = 0; i < points.Length; i++) {
//    points[i] = points[i] + 5;
//}
//foreach (int point in points) {
//    Console.WriteLine(point);
//}

//tring[] students = { "Аня", "Борис", "Вика" };
//nt number = 1;
//
//oreach (string student in students) {
//   Console.WriteLine($"{number}. {student}");
//   number++;
//
///*a
//nt[] numbers = { 3, 8, 1, 6, 4 };
//nt sum = 0;
//oreach (int number in numbers) {
//   Console.WriteLine(number);
//   sum += number;
//
//onsole.WriteLine($"Сумма: {sum}");
///b
//tring[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
//
//oreach (string day in days) {
//   Console.WriteLine($"{day}!");
//

//** 3
string word = "программирование";
string vowels = "аеёиоуыэюя";
int count = 0;

foreach (char letter in word) {
    char lower = char.ToLower(letter);

    if (char.IsLetter(lower) && !vowels.Contains(lower) && lower != 'ъ' && lower != 'ь') {
        count++;
    }
}
Console.WriteLine($"Согласных букв: {count}");
//5 
string[] books = { "Мастер и Маргарита", "Война и мир", "Идиот" };
string target = "Идиот";
bool found = false;
foreach (string book in books) {
    if (book == target) {
        found = true;
    }
}
if (found) {
    Console.WriteLine("Найдено");
} else {
    Console.WriteLine("Не найдено");
}