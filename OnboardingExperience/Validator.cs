using System;
static class Validator
{
        public static int AskQuestionPINCode(string question)
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
        public static string AskQuestionString(string question) 
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
        public static string AskQuestionState(string question) 
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
        public static int AskQuestionZipCode(string question)
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
        public static bool AskQuestionBool(string question)
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
        public static void AskQuestion(string question)
        {
            DisplayUserOutput(question);
        }//AskQuestion//
        public static void EchoResponse(string response)
        {
            DisplayUserOutput(response);
            DisplayUserOutput("Press Enter to Exit");
            GetUserInput();
        }//EchoResponse//
        public static void DisplayErrorText(string errorText)
        {
            DisplayUserOutput(errorText);
        }//DisplayErrorText//
        public static string GetUserInput()
        {
            return Console.ReadLine();
        }//getUserInput//
        public static void DisplayUserOutput(string text)
        {
            Console.WriteLine(text);
        }//DisplayUserOutput//        









}