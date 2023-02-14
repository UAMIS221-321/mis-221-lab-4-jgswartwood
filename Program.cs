int userChoice = GetUserChoice();
while(userChoice != 3){
    Route(userChoice);
    userChoice = GetUserChoice();
}


//END MAIN

static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;

}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput){
    if(userInput == "1" || userInput == "2" || userInput == "3"){
        return true;
    }
        return false;
}

static void GetFull(){
    Random rnd = new Random();
    int num = rnd.Next(7);

    for (int i = 1; i <= num + 3; i++){
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("0");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
    
    PauseAction();
}

static void GetPartial(){
    Random rnd = new Random();
    int num = rnd.Next(7);
    

    for (int i = 1; i <= num + 3; i++){
                for (int k = 1; k <= i; k++)
                {
                    Random rnd2 = new Random();
                    int num2 = rnd2.Next(5);
                    if(num2 == 1){
                        Console.Write(" ");
                        Console.Write(" ");
                    }
                    else{
                    Console.Write("0");
                    Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

    PauseAction();
}

static void SayInvalid(){
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void Route(int menuChoice){
    if(menuChoice == 1){
        GetFull();
    }
    else if(menuChoice == 2){
        GetPartial();        
    }
    else if(menuChoice != 3){
        SayInvalid();
    }
}

static void PauseAction(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}



