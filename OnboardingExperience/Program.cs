using System;
using System.Text;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.LastName=Validator.AskQuestionString("What is your Last Name?");
            user.FirstName=Validator.AskQuestionString("What is your First Name?");
            user.IsAccountOwner=Validator.AskQuestionBool("Are You the Account Owner Y or N?");
            user.Address=Validator.AskQuestionString("What is you Address?");
            user.City=Validator.AskQuestionString("What is your City?");
            user.State=Validator.AskQuestionState("What is your State?");
            user.ZipCode=Validator.AskQuestionZipCode("What is your Zip Code?");
            user.PINNumber=Validator.AskQuestionPINCode("What is your PIN number");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nYour Responses:");
            sb.AppendLine("Name:\t\t" + user.FirstName + " " + user.LastName);
            sb.AppendLine("Address:\t" + user.Address);
            sb.AppendLine("City/ST/Zip:\t" + user.City + "," + user.State + " " + user.ZipCode);
            sb.AppendLine("PIN Code:\t" + user.PINNumber.ToString());
            sb.AppendLine("Account Owner:\t" + user.IsAccountOwner);
            Validator.EchoResponse(sb.ToString());
        }//Main//
    }//Program//
}//Program//
