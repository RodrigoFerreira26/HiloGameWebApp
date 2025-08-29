using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PlayCommand
{
    public class PlayCommandValidator : AbstractValidator<PlayCommand>
    {
        public PlayCommandValidator()
        {
            RuleFor(x => x.MysteryNumber)
                .GreaterThan(0)
                .WithMessage("Mystery number must be greater than 0")
                .LessThanOrEqualTo(1000)
                .WithMessage("Mystery number must be 1000 or less");

            RuleFor(x => x.Number)
                .GreaterThan(0)
                .WithMessage("Guessed number must be greater than 0")
                .LessThanOrEqualTo(1000)
                .WithMessage("Guessed number must be 1000 or less");

            RuleFor(x => x.GameId)
                .GreaterThan(0)
                .When(x => !x.FirstTurn)
                .WithMessage("Game ID must be greater than 0 when provided and must be provided if it is not a first turn");
        }
    }
}
