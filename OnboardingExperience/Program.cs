using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.LastName=AskQuestionString("What is your Last name");
            user.FirstName=AskQuestionString("What is your First Name");
            user.IsAccountOwner=AskQuestionBool("Are You the Account Owner Y or N");
            var owner = (user.IsAccountOwner == true) ? "ARE the account" : "ARE NOT the account";
            EchoResponse($"Thanks for responding your name is {user.FirstName} {user.LastName} and you {owner} owner");
        }
        static string AskQuestionString(string question) 
        {
            AskQuestion(question);
            while(true)
            {
                var response = Console.ReadLine();
                if(response.Length > 2)
                    return response;
                DisplayErrorText("Sorry I could not understand you. I don't see any text. Please enter at least 1 character");
            }//while//
        }//AskQuestion//
        static bool AskQuestionBool(string question)
        {
            AskQuestion(question);
            while(true)
            {
                var response = Console.ReadLine();
                if(response.Equals("Y") || response.Equals("y"))
                    return true;
                if(response.Equals("N") || response.Equals("n"))
                    return false;
                DisplayErrorText("Sorry I was unable to understand your response. Please use only Y(y) for yes or N(n) for no.");
            }
        }

        static void AskQuestion(string question)
        {
            Console.WriteLine(question);
        }
        static void EchoResponse(string response)
        {
            Console.WriteLine(response);
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
        static void DisplayErrorText(string errorText)
        {
            Console.WriteLine(errorText);
        }
    }
}
