using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Hugo_LAND.Core.Models;

namespace Hugo_LAND.Core.Validators
{
    public class ModifAdminValidator : AbstractValidator<ModifAdmin>
    {
        private const string FIRST_NAME_REGEX = @"^[\w\-\s\']+$";
        private const string LAST_NAME_REGEX = @"^[\w\-\s\']+$";
        private const string USERNAME_REGEX = @"^([a-zA-Z0-9]){6,20}$";
        private const string PASSWORD_REGEX = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{8,20})";
        private const int FIRST_NAME_MIN_LENGTH = 2;
        private const int FIRST_NAME_MAX_LENGTH = 50;
        private const int LAST_NAME_MIN_LENGTH = 2;
        private const int LAST_NAME_MAX_LENGTH = 250;



        public ModifAdminValidator()
        {
            //Username
            RuleFor(c => c.NomJoueur)
                .NotEmpty()
                .WithMessage("Please provide a username.")
                .Matches(USERNAME_REGEX)
                .WithMessage("Please provide a valid username (6 to 20 characters, can only be letters or numbers");


            //Password
            RuleFor(c => c.MotDePasse)
                .NotEmpty()
                .WithMessage("Please provide a password.")
                .Matches(PASSWORD_REGEX)
                .WithMessage("Please provide a valid password (8 to 20 characters, at least one uppercase letter, one lowercase letter and one number.");


            //Firstname
            RuleFor(c => c.Prenom)
                .NotEmpty()
                .WithMessage("Please provide a first name.")
                .Length(FIRST_NAME_MIN_LENGTH, FIRST_NAME_MAX_LENGTH)
                .WithMessage($"Please provide a first name between {FIRST_NAME_MIN_LENGTH} and {FIRST_NAME_MAX_LENGTH} caracters.")
                .Matches(FIRST_NAME_REGEX)
                .WithMessage("Please provide a VALID first name (only letters, hyphen, spaces and apostrophe are authorized).");

            //Lastname
            RuleFor(c => c.Nom)
                .NotEmpty()
                .WithMessage("Please provide a last name.")
                .Length(LAST_NAME_MIN_LENGTH, LAST_NAME_MAX_LENGTH)
                .WithMessage($"Please provide a last name between {LAST_NAME_MIN_LENGTH} and {LAST_NAME_MAX_LENGTH} caracters.")
                .Matches(LAST_NAME_REGEX)
                 .WithMessage("Please provide a VALID last name (only letters, hyphen, spaces and apostrophe are authorized).");

            //Email
            RuleFor(c => c.Courriel)
                .NotEmpty()
                .WithMessage("Please provide a last name.")
                .EmailAddress()
                .WithMessage("Please provide a VALID email address.");

        }


    }
}
