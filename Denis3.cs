using System;

class Program {

    static void Main() {

        int[] stats = [8, 8, 8, 8, 8, 8];
        string[] statNames = ["Сила", "Спритність", "Конституція", "Інтелект", "Мудрість", "Харизма"];
        int skills = 27;

        while (skills > 0) {

            Console.WriteLine("\n=== Ваш персонаж ===");
            for (int i = 0; i < stats.Length; i++) {

                Console.WriteLine($"{i + 1}. {statNames[i]}: {stats[i]}");

            }

            Console.WriteLine($"Залишилось очок: {skills}");

            Console.Write("\nВиберіть параметр для прокачки (1-6): ");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (choice < 0 || choice >= stats.Length) {

                Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                continue;

            }

            Console.Write($"Скільки очок витратити на {statNames[choice]}? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++) {

                if (stats[choice] < 13 && skills > 0) {

                    stats[choice]++;
                    skills--;

                }

                else if (stats[choice] < 15 && skills >= 2) {

                    stats[choice]++;
                    skills -= 2;

                }

                else {

                    Console.WriteLine($"Неможливо прокачати {statNames[choice]} вище 15 або недостатньо очок.");
                    break;

                }
            }
        }

        Console.WriteLine("\n=== Прокачка завершена ===");
        for (int i = 0; i < stats.Length; i++) {

            Console.WriteLine($"{statNames[i]}: {stats[i]}");

        }
    }
}
