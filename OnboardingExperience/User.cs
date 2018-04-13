using System.Text;
namespace OnboardingExperience
{
    /*
     *  User Class that defines 
     *  the user.
     */
    public class User
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public bool IsAccountOwner { get; set; }
        public int PINNumber { get; set; }


        /*
         * Build the output response.
         */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nYour Responses:");
            sb.AppendLine("Name:\t\t" + FirstName + " " + LastName);
            sb.AppendLine("Address:\t" + Address);
            sb.AppendLine("City/ST/Zip:\t" + City + "," + State + " " + ZipCode);
            sb.AppendLine("PIN Code:\t" + PINNumber.ToString());
            var yesNo = (IsAccountOwner) ? "YES" : "NO";
            sb.AppendLine("Account Owner:\t" + yesNo);
            return sb.ToString();
        }//ToString//
    }//User//
}//OnboardingExperience//