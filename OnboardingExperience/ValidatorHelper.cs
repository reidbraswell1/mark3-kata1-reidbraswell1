using System;
using System.Text;

namespace OnboardingExperience
{
    /*
     * Static Class Validator Helper
     *
     */
    static class ValidatorHelper
    {
        private const int PIN_NUMBER_LENGTH = 4;
        private const int ZIP_CODE_LENGTH = 5;
        private const int MIN_RESPONSE_LENGTH = 2;

        /*
         * Ask for and validate the pin code.
         */
        public static int AskQuestionPINCode(string question)
        {
            AskQuestion(question);
            while (true)
            {
                var response = Console.ReadLine();
                var number = 0;
                if (response.Length == PIN_NUMBER_LENGTH)
                {
                    if (int.TryParse(response, out number))
                        return number;
                }//if//
                Console.WriteLine($"PIN Number must be {PIN_NUMBER_LENGTH} numeric digits please try again.");
            }//while//
        }//AskQuestionPINCode//

        /*
         * Ask for and validate a general string field..
         */
        public static string AskQuestionString(string question)
        {
            AskQuestion(question);
            while (true)
            {
                var response = Console.ReadLine();
                if (response.Length >= MIN_RESPONSE_LENGTH)
                    return response;
                Console.WriteLine($"Sorry I could not understand you. I don't see any text. Please enter at least {MIN_RESPONSE_LENGTH} characters");
            }//while//
        }//AskQuestionString//

        /*
         * Ask for and validate the state code.
         */
        public static string AskQuestionState(string question)
        {
            AskQuestion(question);
            while (true)
            {
                var response = Console.ReadLine();
                if (Enum.IsDefined(typeof(States), response.ToUpper()))
                    return response.ToUpper();
                Console.WriteLine("Sorry I did not get your State Code please use the standard state code abbreviations");
            }
        }//AskQuestionState//

        /*
         * Ask for and validate the zip code.
         */
        public static int AskQuestionZipCode(string question)
        {
            AskQuestion(question);
            while (true)
            {
                var response = Console.ReadLine();
                var zip = 0;
                if (response.Length == ZIP_CODE_LENGTH)
                {
                    if (int.TryParse(response, out zip))
                        return zip;
                }
                Console.WriteLine($"Your Zip Code must be {ZIP_CODE_LENGTH} numeric digits - Please re-enter.");
            }
        }//AskQuestionZipCode//

        /*
         * Ask for and validate boolean input.
         */
        public static bool AskQuestionBool(string question)
        {
            AskQuestion(question);
            while (true)
            {
                var response = Console.ReadLine();
                if (response.Equals("Y") || response.Equals("y"))
                    return true;
                if (response.Equals("N") || response.Equals("n"))
                    return false;
                Console.WriteLine("Sorry I was unable to understand your response. Please use only Y(y) for yes or N(n) for no.");
            }//while//
        }//AskQuestionBool//

        /*
         * Helper method for asking a question.
         */
        private static void AskQuestion(string question)
        {
            Console.WriteLine(question);
        }//AskQuestion//

        /*
         * Display the response and pause screen so user can view response.
         */
        public static void EchoResponse(string response)
        {
            Console.WriteLine(response);
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }//EchoResponse//
    }//ValidatorHelper//
}//OnboardingExperience//