
public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        // CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        // CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        // CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"
        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(1);
        CheckForPositiveNegativeZero(0);
        FindMinimum(1,2,3);
        FindMinimum(2,1,3);
        FindMinimum(3,2,1);
        FindMaximum(1,2,3);
        FindMaximum(2,1,3);
        FindMaximum(3,2,1);
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);
        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);
    }
    
    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int number) 
    {
        if (number>0) {
            Console.WriteLine("Your number is positive.");
        } else if (number<0){
            Console.WriteLine("Your number is negative.");
        } else {
            Console.WriteLine("Your number is zero.");
        }
    }
    public static void FindMinimum(int num1, int num2, int num3) {
        if(num1 < num2 & num1 < num3){
            Console.WriteLine("The minimum number is "+num1);
        } else if (num2 < num1 & num2 < num3){
            Console.WriteLine("The minimum number is "+num2);
        } else {
            Console.WriteLine("The minimum number is "+num3);
        }
    }
    public static void FindMaximum(int num1, int num2, int num3){
        if(num1 > num2 & num1 > num3){
            Console.WriteLine("The maximum number is "+num1);
        } else if (num2 > num1 & num2 > num3){
            Console.WriteLine("The maximum number is "+num2);
        } else {
            Console.WriteLine("The maximum number is "+num3);
        }
    }
    public static void IsDivisibleBy5(int number) {
        if (number%5==0){
            Console.WriteLine(number+" is divsible by 5.");
        } else {
            Console.WriteLine(number+" is not divsible by 5.");
        }
    }
    public static void CheckEvenOrOdd(int number) {
        if(number%2==0){
            Console.WriteLine(number+" is an even number.");
        } else {
            Console.WriteLine(number+" is an odd number.");
        }
    }
    public static void CheckVowelOrConsonant(char letter){
        char lowerCaseLetter = Char.ToLower(letter);
        char[] vowels = {'a','e','i','o','u'};
        Boolean isVowel = false;
        for(int i =0; i<vowels.Length;i++){
            if(lowerCaseLetter == vowels[i]){
                isVowel=true;
                break;
            }
        }
        if(isVowel==true){
            Console.WriteLine(letter+" is a vowel.");
        } else {
            Console.WriteLine(letter+" is a consonant.");
        }
    }
    public static void DisplayDayOfWeek(int dayCode){
        switch (dayCode){
            case 0:
            Console.WriteLine("Sunday");
            break;
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wednesday");
            break;
            case 4:
            Console.WriteLine("Thursday");
            break;
            case 5:
            Console.WriteLine("Friday");
            break;
            case 6:
            Console.WriteLine("Saturday");
            break;
        }
    }
}
