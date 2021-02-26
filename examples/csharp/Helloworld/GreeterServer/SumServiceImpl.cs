using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using static SumService;

namespace GreeterServer
{
  class SumServiceImpl : SumServiceBase
  {

    public override Task<SumResponse> SumNumbers(SumRequest request, ServerCallContext context)
    {
      var response = new SumResponse() { Result = request.Numbers.ToList().Sum() };
      return Task.FromResult(response);
    }
  }
}

