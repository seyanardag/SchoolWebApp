using EntityLayer.Entities;
using FluentValidation;
using WebUI.UIDtos.StudentDto;

namespace WebUI.UIDtos.Validations
{
    public class CreateStudentDtoUIValidator : AbstractValidator<CreateStudentDtoUI>
    {
        public CreateStudentDtoUIValidator()
        {
            RuleFor(x => x.FirstName)
              .NotEmpty().WithMessage("Ad alanı zorunludur.")
              .MinimumLength(3).WithMessage("En az 3 karakter giriniz.")
              .MaximumLength(30).WithMessage("En fazla 30 karakter giriniz.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad zorunludur.")
                .MinimumLength(3).WithMessage("En az 3 karakter giriniz.")
                .MaximumLength(30).WithMessage("En fazla 30 karakter giriniz.");

            RuleFor(x => x.BirthDate)
                .NotEmpty().WithMessage("Doğum Tarihi zorunludur.")
                .LessThan(DateTime.Now).WithMessage("Doğum tarihi gelecekte olamaz.");

            RuleFor(x => x.EnrollmentDate)
                .NotEmpty().WithMessage("Kayıt Tarihi zorunludur.")
                .LessThan(DateTime.Now).WithMessage("Kayıt tarihi gelecekte olamaz.");

        }
    }
}
