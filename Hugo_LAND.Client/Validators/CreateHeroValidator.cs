using FluentValidation;
using Hugo_LAND.Client.HugoLandServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Client.Validators
{
    class CreateHeroValidator : AbstractValidator<HeroDetailsDTO>
    {
        private const string NAME_REGEX = @"^([a-zA-Z -]){2,20}$";

        public CreateHeroValidator()
        {
            //Name
            RuleFor(h => h.HeroName)
                .NotEmpty()
                .WithMessage("Please provide a hero name.")
                .Matches(NAME_REGEX)
                .WithMessage("Please provide a valid hero name (2 to 20 characters, can only be letters");
        }
    }
}
