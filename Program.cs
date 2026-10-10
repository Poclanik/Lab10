string subject = "Программирование";

foreach (char letter in subject) {
    Console.WriteLine(letter);
}

Console.WriteLine($"Всего букв: {subject.Length}");

int[] grad = { 4, 5, 3, 5, 4 };
int sum = 0;

foreach (int i in grad) {
    Console.WriteLine(i);
    sum += i;
}

double cred = (double)sum / grad.Length;
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Средний балл: {cred}");
