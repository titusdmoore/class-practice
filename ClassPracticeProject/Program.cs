using System;

namespace ClassPracticeProject {
    class Program {
        static void Main(string[] args) {
            Friend alex = new Friend("Alex", "Chan");
            alex.age = 25;
            Console.WriteLine($"My one and only friend is {alex.firstName} {alex.lastName} and he is {alex.age} years old\");
        }
    }
    class Friend { 
        public int age { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        public Friend( string FirstName, string LastName) {
            this.firstName = FirstName;
            this.lastName = LastName;
        }
    }
}
