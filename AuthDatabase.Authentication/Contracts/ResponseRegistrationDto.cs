namespace AuthDatabase.Authentication.Contracts;

public class ResponseRegistrationDto
{
    public bool IsRegistrationSuccessful { get; set; }
    public IEnumerable<string>? Errors { get; set; }
}
