using FluentValidation;
using KatmanliBurger.WebUI.DTOs.BurgerViewDtos;
using KatmanliBurger.WebUI.Helpers;

namespace KatmanliBurger.WebUI.ValidationRules.BurgerDtosValidations
{
    public class BurgerUpdateDtoValidator : AbstractValidator<BurgerUpdateDto>
    {
        public BurgerUpdateDtoValidator()
        {
            RuleFor(s => s.Name).MinimumLength(5).WithMessage(ErrorMessageProvider.GetErrorMessage("Deneme"));
            RuleFor(s => s.Price).NotEqual(0).WithMessage(ErrorMessageProvider.GetErrorMessage("Deneme"));
        }
    }
}
