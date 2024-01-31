using MiasHR.Api.Entities;

public interface IJwtAuthenticationService
{
    string CreateToken(HrEmployee employee, bool isManager);
}
