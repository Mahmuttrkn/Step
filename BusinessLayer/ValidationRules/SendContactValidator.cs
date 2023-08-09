using DTOLayer.DTOS.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public class SendContactValidator : AbstractValidator<SendMessageDTO>
    {
        public SendContactValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Bilgisi Boş Geçilemez");
            RuleFor(x => x.Name).MaximumLength(10).WithMessage("İsim Bilgisi En Fazla 10 Karakter Olmalıdır.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Boş Geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("İçerik Boş Bırakılamaz");
            RuleFor(x => x.MessageBody).MaximumLength(50).WithMessage("İçerik En Fazla 50 Karakter olmalıdır.");
        }

    }
}
