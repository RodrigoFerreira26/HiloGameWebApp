
using Cqrs.Commands;
using MediatR;
namespace Application.PlayCommand
{
    public sealed record PlayCommand(int MysteryNumber, int Number, bool FirstTurn, long? GameId) : IRequest<PlayCommandResponse>;
}
