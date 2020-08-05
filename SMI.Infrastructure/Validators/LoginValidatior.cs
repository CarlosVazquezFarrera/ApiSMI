namespace SMI.Infrastructure.Validators
{
    using FluentValidation;
    using SMI.Core.DTOs;

    public class LoginValidatior : AbstractValidator<EmpleadoDto>
    {
        public LoginValidatior()
        {
            RuleFor(empleado => empleado.Email)
                .NotNull();
            RuleFor(empleado => empleado.Password)
               .NotNull();
        }
    }
}
