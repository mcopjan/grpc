// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/sum.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class SumService
{
  static readonly string __ServiceName = "SumService";

  static readonly grpc::Marshaller<global::SumRequest> __Marshaller_SumRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SumRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::SumResponse> __Marshaller_SumResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SumResponse.Parser.ParseFrom);

  static readonly grpc::Method<global::SumRequest, global::SumResponse> __Method_SumNumbers = new grpc::Method<global::SumRequest, global::SumResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "SumNumbers",
      __Marshaller_SumRequest,
      __Marshaller_SumResponse);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::SumReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of SumService</summary>
  [grpc::BindServiceMethod(typeof(SumService), "BindService")]
  public abstract partial class SumServiceBase
  {
    public virtual global::System.Threading.Tasks.Task<global::SumResponse> SumNumbers(global::SumRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for SumService</summary>
  public partial class SumServiceClient : grpc::ClientBase<SumServiceClient>
  {
    /// <summary>Creates a new client for SumService</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    public SumServiceClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for SumService that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    public SumServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    protected SumServiceClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    protected SumServiceClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    public virtual global::SumResponse SumNumbers(global::SumRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return SumNumbers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::SumResponse SumNumbers(global::SumRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_SumNumbers, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::SumResponse> SumNumbersAsync(global::SumRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return SumNumbersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::SumResponse> SumNumbersAsync(global::SumRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_SumNumbers, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    protected override SumServiceClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new SumServiceClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static grpc::ServerServiceDefinition BindService(SumServiceBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_SumNumbers, serviceImpl.SumNumbers).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static void BindService(grpc::ServiceBinderBase serviceBinder, SumServiceBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_SumNumbers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SumRequest, global::SumResponse>(serviceImpl.SumNumbers));
  }

}
#endregion