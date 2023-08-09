using DTOLayer.DTOS.Announcement;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Boş Geçilemez");
        }
    }
}
