using backend.Src.Application.Validators;

namespace backend.Src.Application.Services;


public class UserService
{
    private readonly AuthValidator _authValidator;

    public UserService(AuthValidator authValidator)
    {
        _authValidator = authValidator;
    }

    public string Register(string email, string password)
    {
        _authValidator.ValidateRegister(email, password);

        // Placeholder logic
        return "User registered successfully";
    }

    public string Login(string email, string password)
    {
        _authValidator.ValidateLogin(email, password);

        // Would call repository + JWT generation here
        return "fake.jwt.token";
    }

    public string ChangePassword(Guid userId, string oldPassword, string newPassword)
    {
        // Placeholder – validate and call repo
        return "Password changed";
    }
}
