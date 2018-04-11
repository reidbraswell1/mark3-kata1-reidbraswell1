using System;
using System.Text;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.LastName=AskQuestionString("What is your Last Name?");
            user.FirstName=AskQuestionString("What is your First Name?");
            user.IsAccountOwner=AskQuestionBool("Are You the Account Owner Y or N?");
            user.Address=AskQuestionString("What is you Address?");
            user.City=AskQuestionString("What is your City?");
            user.State=AskQuestionState("What is your State?");
            user.ZipCode=AskQuestionZipCode("What is your Zip Code?");
            user.PinNumber=AskQuestionPINCode("What is your PIN number");
            var owner = (user.IsAccountOwner == true) ? "ARE the account" : "ARE NOT the account";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nThanks for responding your name is:");
            sb.AppendLine(user.FirstName + " " + user.LastName);
            sb.AppendLine("You " + owner + " owner.");
            sb.AppendLine("You live at:");
            sb.AppendLine(user.Address);
            sb.AppendLine(user.City + "," + user.State + "," + user.ZipCode);
            sb.AppendLine("Your PIN Code is:");
            sb.AppendLine(user.PinNumber.ToString());
            EchoResponse(sb.ToString());
        }
        static int AskQuestionPINCode(string question)
        {
            AskQuestion(question);
            while(true)
            {
                var response = GetUserInput();
                var number = 0;
                if(int.TryParse(response, out number))
                    return number; 
                DisplayErrorText("PIN Number must be 4 numeric digits please try again.");
            }//while//
        }//AskQuestionPINCode//
        static string AskQuestionString(string question) 
        {
            AskQuestion(question);
            while(true)
            {
                var response = GetUserInput();
                if(response.Length > 1)
                    return response;
                DisplayErrorText("Sorry I could not understand you. I don't see any text. Please enter at least 2 characters");
            }//while//
        }//AskQuestionString//
        static string AskQuestionState(string question) 
        {
            AskQuestion(question);
            while(true)
            {
                var response = Console.ReadLine();
                if(Enum.IsDefined(typeof(States), response))
                    return response;
                DisplayErrorText("Sorry I did not get your State Code please use an upper case 2 digit letter");
            }
        }//AskQuestionState//
        static int AskQuestionZipCode(string question)
        {
            AskQuestion(question);
            while(true)
            {
                var response = GetUserInput();
                var zip = 0;
                if(int.TryParse(response, out zip))
                    return zip;
                DisplayErrorText("Your Zip Code is not numeric - Please re-enter a numeric zip code");
            }
        }//AskQuestionZipCode//
        static bool AskQuestionBool(string question)
        {
            AskQuestion(question);
            while(true)
            {
                var response = GetUserInput();
                if(response.Equals("Y") || response.Equals("y"))
                    return true;
                if(response.Equals("N") || response.Equals("n"))
                    return false;
                DisplayErrorText("Sorry I was unable to understand your response. Please use only Y(y) for yes or N(n) for no.");
            }//while//
        }//AskQuestionBool//
        static void AskQuestion(string question)
        {
            DisplayUserOutput(question);
        }//AskQuestion//
        static void EchoResponse(string response)
        {
            DisplayUserOutput(response);
            DisplayUserOutput("Press Enter to Exit");
            GetUserInput();
        }//EchoResponse//
        static void DisplayErrorText(string errorText)
        {
            Console.WriteLine(errorText);
        }//DisplayErrorText//
        static string GetUserInput()
        {
            return Console.ReadLine();
        }//getUserInput//
        static void DisplayUserOutput(string text)
        {
            Console.WriteLine(text);
        }//DisplayUserOutput//
    }//Main//
}//Program//
