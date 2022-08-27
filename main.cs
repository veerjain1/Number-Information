using System;

class Program {
  public static void Main (string[] args) {
    
    
    string userInput = "" ;//asign variable value for user's input

    int num = 0; //assign value to integer
    bool isGreater99;//Declare boolean
    bool isLess10;//Declare boolean
    bool isEven;//Declare boolean
    bool isOdd;//Declare boolean
    int a;//declare integer variable for determining if it is even or odd

    Console.Write("Enter a 2 digit positive integer: ");
    userInput = Console.ReadLine();
    num = int.Parse(userInput);//parse the string of user input into an integer

    isGreater99=(num>99);//checks to see if the number is greater than 99- changes value of boolen accordingly
    isLess10=(num<10);//checks to see if the number is less than 10- changes value of boolen accordingly
    a = (num%2);//assigns variable to the value of the user input mod 2--->determines odd/even
    isEven=(a==0);//checks to see if the number's remainder is equal to 0- changes value of boolen accordingly
    isOdd=(a!=0);//checks to see if the number's remainder is not to 0---> changes value of boolen accordingly

    Console.WriteLine("Greater than 99:\t\t\t \t"+isGreater99);//prints final values...
    Console.WriteLine("Less than 10: \t\t\t\t\t"+isLess10);
    Console.WriteLine("Even: \t\t\t\t\t\t\t"+isEven);
    Console.WriteLine("Odd: \t\t\t\t\t\t\t"+isOdd);
    Console.WriteLine("(Press enter to continue)");
    Console.ReadLine();

        //---------MEXT QUESION---------------

    Console.Write("Enter a 2 digit positive integer: ");
    userInput = Console.ReadLine();
    num = int.Parse(userInput);

    isGreater99=(num>99);
    isLess10=(num<10);
    a = (num%2);
    isEven=(a==0);
    isOdd=(a!=0);

    Console.WriteLine("Greater than 99: \t\t\t\t"+isGreater99);
    Console.WriteLine("Less than 10: \t\t\t\t\t"+isLess10);
    Console.WriteLine("Even: \t\t\t\t\t\t\t"+isEven);
    Console.WriteLine("Odd: \t\t\t\t\t\t\t"+isOdd);
    Console.WriteLine("(Press enter to continue)");
    Console.ReadLine();
    

    //---------MEXT QUESION---------------

    Console.Write("Enter a 2 digit positive integer: ");
    userInput = Console.ReadLine();
    num = int.Parse(userInput);

    isGreater99=(num>99);
    isLess10=(num<10);
    a = (num%2);
    isEven=(a==0);
    isOdd=(a!=0);

    Console.WriteLine("Greater than 99: \t\t\t\t"+isGreater99);
    Console.WriteLine("Less than 10: \t\t\t\t\t"+isLess10);
    Console.WriteLine("Even: \t\t\t\t\t\t\t"+isEven);
    Console.WriteLine("Odd: \t\t\t\t\t\t\t"+isOdd);
    Console.WriteLine("(Press enter to exit)");
    Console.ReadLine();
    


  }
}