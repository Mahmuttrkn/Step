using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Boş Bırakılamaz.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel Boş Bırakılamaz.");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("En Az 10 Karakter Girişi Sağlayınız");
           // RuleFor(x => x.Link1).MinimumLength(20).WithMessage("Boş Bıraklımaz");
            //RuleFor(x => x.Link2).MinimumLength(20).WithMessage("Boş Bıraklımaz");
        }
    }
}
