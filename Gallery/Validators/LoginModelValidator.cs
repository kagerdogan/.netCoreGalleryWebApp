using FluentValidation;
using Gallery.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Validators
{
    public class LoginModelValidator:AbstractValidator<LoginModel>
    {
        public LoginModelValidator()
        {
            RuleFor(x => x.Username).NotNull().WithMessage("Invalid Username")
                .NotEmpty().WithMessage("please enter username");
            RuleFor(x => x.Password).NotNull().WithMessage("Invalid password")
                .NotEmpty().WithMessage("please enter password");
        }
    }
}
