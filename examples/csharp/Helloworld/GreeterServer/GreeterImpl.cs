using System;
using System.Threading.Tasks;
using Greeterudemy;
using Grpc.Core;

namespace GreeterServer
{
  class GreeterImpl : Greeterudemy.GreetingService.GreetingServiceBase
  {
    public override Task<GreetingResponse> Greet(GreetingRequest request, ServerCallContext context)
    {
      return Task.FromResult(new GreetingResponse { Result = $"Hello you {request.Person.FirstName} {request.Person.LastName}! How are you?" });
    }

  }
}
