//Kent Tupas
//10/19/2022
//github mini challenge 8
// update and upload to github
//



string input = "yes";
Console.WriteLine("Welcome to guess it");
Console.WriteLine("");
while(input != "no"){
Console.WriteLine("There are 3 levels easy, medium, and hard");
Console.WriteLine("Can you complete all 3 levels");
Console.WriteLine("");
Console.WriteLine("Easy");
Random random = new Random();
int num1 = random.Next(1,10);
int guess = 0;
Console.WriteLine("Thinking of a number between 1 -10");
while(guess != num1){
    string notnum = Console.ReadLine();
    if(!int.TryParse(notnum, out guess))
       Console.WriteLine("Please give a number -_-");
       
        else if(guess < num1){
        Console.WriteLine($"Nope, higher than {guess}. Try Again");
       }

       else if(guess > num1 ){
        Console.WriteLine($"Nope, lower than {guess}. Try Again ");
       }
}

Console.WriteLine($"Great job! The answer was {num1}");
Console.WriteLine("");
Console.WriteLine("Next Level");
Console.WriteLine("");
Console.WriteLine("Welcome to level 2");
Console.WriteLine("");
Console.WriteLine("Medium");
Random random2 = new Random();
int num2 = random2.Next(1,50);
int guess2 = 0;
Console.WriteLine("Thinking of a number between 1 - 50");
while(guess2 != num2){
     string notnum2 = Console.ReadLine();
     if(!int.TryParse(notnum2, out guess2))
        Console.WriteLine("Please give a number -_-");
         
         else if(guess2 < num2){
            Console.WriteLine($"Nope, higher then {guess2}. Try Again");
         }

         else if(guess2 > num2){
            Console.WriteLine($"Nope, lower than {guess2}. Try again");
            
         } 
}
Console.WriteLine($"Great job! The answer was {num2}");
Console.WriteLine("");
Console.WriteLine("Next Level");
Console.WriteLine("");
Console.WriteLine("Welcome to level 3");
Console.WriteLine("");
Console.WriteLine("Hard");
Random random3 = new Random();
int num3 = random3.Next(1,100);
int guess3 = 0;
Console.WriteLine("Thinking of a number between 1 - 100");
while(guess3 != num3){
     string notnum3 = Console.ReadLine();
     if(!int.TryParse(notnum3, out guess3))
        Console.WriteLine("Please give a number -_-");
         
         else if(guess3 < num3){
            Console.WriteLine($"Nope, higher then {guess3}. Try Again");
         }

         else if(guess3 > num3){
            Console.WriteLine($"Nope, lower than {guess3}. Try again");

         } 
}
     Console.WriteLine($"Great job! The answer was {num3}");
     Console.WriteLine("Want to try again yes or no");
     input = Console.ReadLine();
}
     
         