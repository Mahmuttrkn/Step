using DTOLayer.DTOS.AppUserDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AppUserRegisterValidatior: AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidatior()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Boş Geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(x => x.Username).MaximumLength(10).WithMessage("Kullanıcı Adı En fazla 10 Karakter Olabilir.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Geçerli Bir Mail Adresi Giriniz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Your password cannot be empty")
                      .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                      .MaximumLength(16).WithMessage("Your password length must not exceed 16.")
                      .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                      .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                      .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
                      .Matches(@"[\!\?\*\.]+").WithMessage("Your password must contain at least one (!? *.).");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler Uyuşmuyor.");
                     
        }

    }
}
