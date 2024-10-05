namespace ConsoleApp1
{
    internal class Program
    {
        static void CheckOTP ()
        {
            Random random = new Random();
            int generatedOTP = random.Next(100000, 999999);
            Console.WriteLine($"This is the OTP Code {generatedOTP}");
            Console.WriteLine("Enter the OTP code: ");
            string inputOTP = Console.ReadLine();
            int userOTP = 0;
            bool isInputOTPIsNumber = int.TryParse(inputOTP, out userOTP);

            if (!isInputOTPIsNumber)
            {
                Console.WriteLine("invalid input OTP");
                Environment.Exit(0);
            }

            if (userOTP != generatedOTP)
            {
                Console.WriteLine("invalid OTP");
                Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {
            const string USERNAME = "username";
            const string PASSWORD = "password";
            Console.WriteLine("welcome to the simple login system!");
            
            Console.WriteLine("Enter username:");
            string inputUser = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string inputPassword = Console.ReadLine();
            
            bool isValidInputs = inputUser == USERNAME && inputPassword == PASSWORD;
            if (!isValidInputs ) {
                Console.WriteLine("invalid credentials");
                Environment.Exit(0);
            }

            CheckOTP();
           
            
            Console.WriteLine("you are logged in");

        }
    }
}
