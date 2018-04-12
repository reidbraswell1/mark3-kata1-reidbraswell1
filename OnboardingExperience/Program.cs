using System;
using System.Text;
using static ValidatorHelper;

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

            EchoResponse((BuildOutputResponse(user)).ToString());
        }//Main//
    }//Program//
}//Program//
