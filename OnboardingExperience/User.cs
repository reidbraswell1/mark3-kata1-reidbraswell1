namespace OnboardingExperience
{
    /*
     *  User Class that defines 
     *  the user.
     */
    public class User {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public bool IsAccountOwner { get; set; }
        public int PINNumber { get; set; }

        // Default Constructor
        public User() 
         {

        }//UserConstructor//
    }//User//
}//OnboardingExperience//