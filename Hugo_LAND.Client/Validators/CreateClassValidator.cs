using FluentValidation;
using Hugo_LAND.Client.HugoLandServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Client.Validators
{
    public class CreateClassValidator : AbstractValidator<ClassDetailsDTO>
    {
        private const string NAME_REGEX = @"^([a-zA-Z -]){2,20}$";
        private const string DESCRIPTION_REGEX = @"^([a-zA-Z0-9. ]){2,250}$";

        public CreateClassValidator()
        {
            //Name
            RuleFor(c => c.NomClasse)
                .NotEmpty()
                .WithMessage("Please provide a name.")
                .Matches(NAME_REGEX)
                .WithMessage("Please provide a valid name (2 to 20 characters, can only be letters");


            //Description
            RuleFor(c => c.Description)
                .NotEmpty()
                .WithMessage("Please provide a description.")
                .Matches(DESCRIPTION_REGEX)
                .WithMessage("Please provide a valid description (2 to 250 characters, can only be letters and numbers");

        }
    }
}
