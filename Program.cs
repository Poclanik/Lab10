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

string[] students = { "Аня", "Ярослав", "Вика" };
int count = 0;
foreach (string student in students) {
    Console.WriteLine(student);
    count++;
}
Console.WriteLine($"Всего учеников: {count}");

int[] spis = { 10, 20, 15 };
for (int i = 0; i < point.Length; i++) {
    point[i] = point[i] + 5;
}
foreach (int spis in point) {
    Console.WriteLine(point);
}