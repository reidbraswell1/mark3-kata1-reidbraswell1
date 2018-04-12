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
            user.PINNumber=AskQuestionPINCode("What is your PIN number");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nYour Responses:");
            sb.AppendLine("Name:\t\t" + user.FirstName + " " + user.LastName);
            sb.AppendLine("Address:\t" + user.Address);
            sb.AppendLine("City/ST/Zip:\t" + user.City + "," + user.State + " " + user.ZipCode);
            sb.AppendLine("PIN Code:\t" + user.PINNumber.ToString());
            sb.AppendLine("Account Owner:\t" + user.IsAccountOwner);
            EchoResponse(sb.ToString());
        }
        static int AskQuestionPINCode(string question)
        {
            AskQuestion(question);
            while(true)
            {
                var response = GetUserInput();
                var number = 0;
                if(response.Length == 4)
                {
                    if(int.TryParse(response, out number))
                        return number;
                }//if//
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
                if(Enum.IsDefined(typeof(States), response.ToUpper()))
                    return response.ToUpper();
                DisplayErrorText("Sorry I did not get your State Code please use the standard state code abbreviations");
            }
        }//AskQuestionState//
        static int AskQuestionZipCode(string question)
        {
            AskQuestion(question);
            while(true)
            {
                var response = GetUserInput();
                var zip = 0;
                if(response.Length == 5) {
                    if(int.TryParse(response, out zip))
                        return zip;
                }
                DisplayErrorText("Your Zip Code must be 5 numeric digits - Please re-enter.");
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
            DisplayUserOutput(errorText);
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
