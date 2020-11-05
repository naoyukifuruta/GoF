using System;

namespace Mediator
{
    public interface IColleague
    {
        void SetMediator(IMediator mediator);
        void SetColleagueEnabled(bool enabled);
    }
}
