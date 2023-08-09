using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AboutValidatior:AbstractValidator<About>
    {
        public AboutValidatior()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Bırakılamaz.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Görsel Boş Bırakılamaz.");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("En Az 20 Karakter Girişi Sağlayınız");
           
        }
    }
}
