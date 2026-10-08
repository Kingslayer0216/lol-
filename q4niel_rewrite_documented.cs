// Ignore all 'class' and 'static' keywords for now, OOP shit to be continue...

/*
    C#s Real Entry Point. This is always used, if not defined, it is hidden.
    Always use this, ya nooby.

    class Program {
        static void Main(string[] args) {
            // this is your program
        }
    }
*/

// This is OOP shit, again, to be contiue...
class Program {

    // 'Main' is a function, which takes one argument 'args' of type 'string[]', and returns 'void', 'void' means nothing
    // 'args' is a 'container', housing multiple 'elements' of 'datatype' 'string'
    // The 'Main' function is special, and it's definition absolute, meaning you cannot rewrite it 'static void Main(string[] args)'
    // Your kernel calls it, and provides the 'argument's, which is 'args'
    // Your kernel pass 'command line arguments' into 'args', flags on Linux for example
    static void Main(string[] args) {

        // An infinite loop, the 'condition' (true) never changes, since it's a 'literal' value, like 'false', '67', '13.37' or '"random string idk"'
        // 'contiue' is used throughout this code, which immediately reruns the loop
        while (true) {
            // Assign the return value of 'whoWalks' to the variable 'answer' of 'datatype' 'integer'
            int answer = whoWalks();

            // Ensure the users answer is within bounds, if not, call 'clear', trash talk the user, and 'continue' the infinite loop
            // 'answer' is less than '4' or '||' more or equal to '0'
            if (answer > 4 || answer <= 0) {
                clear();
                Console.WriteLine($"{answer}?... eru blind elle?");
                continue;
            }

            // A 'switch' statement switches on something, this case 'answer'
            // A 'case' runs immediately if it's 'condition' is met, compared to if-else chaining, were each statement would instead run after one another
            // Only one 'case' runs, more optimized, arguably easier to read
            // 'switch' on the 'answer', each 'case' calls 'clear', logs something, then 'continues' the infinite loop, except 'case 2'
            switch (answer) {
                case (1): {
                    clear();
                    Console.WriteLine("Nej jacob kan inte gå och han stavar med K");
                    continue;
                }

                // 'case 2' 'return's instead of 'continue'ing the infinite loop
                case (2): {
                    clear();
                    Console.WriteLine("Ja det är Danne som går");
                    // 'return' is a function related 'keyword', this statement 'return's the 'Main' function
                    // which result in the program exiting
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

    // 'clear' is a function, which takes zero arguments 'parenthesis are empty (...)', and returns 'void', 'void' means nothing
    static void clear() {
        // This is obvious
        Console.Clear();
    }

    // 'whoWalks' is a function, which takes zero arguments 'parenthesis are empty (...)', and returns an 'integer'
    static int whoWalks() {
        // Define a string array 'string[]', an array is a 'container', holding multiple 'element's of the same 'datatype', 'string's in this case
        string[] msg = [
            "Vem är det som går??",
            "  1. Jacob",
            "  2. Daniel",
            "  3. Adam",
            "  4. Andreas"
        ];

        // A 'foreach' loop 'iterate's through a 'container', in this case 'msg', and assigns each 'element' to a variable for ease of use 'string s'
        foreach (string s in msg) {
            // Print 's'... duhh
            Console.WriteLine(s);
            // If 'msg' has more 'element's, rerun the loop with the next 'element'
        }

        // 'return' user input, and parse it as an 'integer' using 'int.Parse(...)'
        // 'return's an 'integer' since the function is defined to do so
        return int.Parse(Console.ReadLine());
    }
}