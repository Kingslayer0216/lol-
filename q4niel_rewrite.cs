class Program {
    static void Main(string[] args) {
        while (true) {
            int answer = whoWalks();

            if (answer > 4 || answer <= 0) {
                clear();
                Console.WriteLine($"{answer}?... eru blind elle?");
                continue;
            }

            switch (answer) {
                case (1): {
                    clear();
                    Console.WriteLine("Nej jacob kan inte gå och han stavar med K");
                    continue;
                }

                case (2): {
                    clear();
                    Console.WriteLine("Ja det är Danne som går");
                    return;
                }

                case (3): {
                    clear();
                    Console.WriteLine("Na Adam går i Falun\nLarper");
                    continue;
                }

                case (4): {
                    clear();
                    Console.WriteLine("Nej Andreas går normalt\nLarper");
                    continue;
                }
            }
        }
    }

    static void clear() {
        Console.Clear();
    }

    static int whoWalks() {
        string[] msg = [
            "Vem är det som går??",
            "  1. Jacob",
            "  2. Daniel",
            "  3. Adam",
            "  4. Andreas"
        ];

        foreach (string s in msg) {
            Console.WriteLine(s);
        }

        return int.Parse(Console.ReadLine());
    }
}