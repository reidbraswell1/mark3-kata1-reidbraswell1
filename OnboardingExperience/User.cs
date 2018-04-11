/*
 *  User Class that defines 
 *  the user.
 */
public class User {

    public string LastName { get; set; }
    public string FirstName { get; set; }

    private bool IsAccountOwner { get; set; };

    public byte PinNumber { get; set; }
}