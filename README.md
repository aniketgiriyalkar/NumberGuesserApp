# Number Guesser App
 A .NET Application written in C# which is a game to guess a number between 1 - 10. The number is randomly generated and the users input is checked if it matches the randomly generated number. 
 
 Flow of the program:
 - GetAppInfo - Gets the Application Info like: App Name, App Version, and App Author
 - GreetUserInfo - Asks for the user name and prints a Welcome message
 - while(True) loop that contains the logic of the Application
   - Generate a random number using the inbuilt Random class and initialize the guess var
   - ask the user for an input number
   - While guess number not equal to correct number 
    - take Input from the user asking for their guess.
    - parse that value to an integer value and check if the value entered is a valid  one
    - print an error message in Red text on the console asking the user to enter a valid number and start from the while loop (use continue)
    - if the number entered is not equal to generated number
    - print in red text on console asking the user to guess again
   - If the guessed number  is correct. Print the success message on console in green color.
   - Ask the user if they want to continue playing.
   - Based on their input(Y or N), take the appropriate action. Y result to starting the next iteration of while(True) loop and N results to termination of the application.
   
   
 Future Scope:
 - Add a fixed/ user stated number of tries to guess the number correctly.
 - Have this game set up for multiple players so that many players can play at the same time.
 - Build a hangman game based on a similar concept.
     