// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPCGreet {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class PhraseService
  {
    static readonly string __ServiceName = "greet.PhraseService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCGreet.PhrasesRequest> __Marshaller_greet_PhrasesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCGreet.PhrasesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCGreet.PhrasesResponce> __Marshaller_greet_PhrasesResponce = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCGreet.PhrasesResponce.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCGreet.PhraseRequest> __Marshaller_greet_PhraseRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCGreet.PhraseRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCGreet.Phrase> __Marshaller_greet_Phrase = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCGreet.Phrase.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCGreet.HelloRequest> __Marshaller_greet_HelloRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCGreet.HelloRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCGreet.HelloReply> __Marshaller_greet_HelloReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCGreet.HelloReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCGreet.PhrasesRequest, global::gRPCGreet.PhrasesResponce> __Method_GetPhrases = new grpc::Method<global::gRPCGreet.PhrasesRequest, global::gRPCGreet.PhrasesResponce>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPhrases",
        __Marshaller_greet_PhrasesRequest,
        __Marshaller_greet_PhrasesResponce);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCGreet.PhraseRequest, global::gRPCGreet.Phrase> __Method_GetSpecificPhrase = new grpc::Method<global::gRPCGreet.PhraseRequest, global::gRPCGreet.Phrase>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSpecificPhrase",
        __Marshaller_greet_PhraseRequest,
        __Marshaller_greet_Phrase);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCGreet.Phrase, global::gRPCGreet.Phrase> __Method_AddPhrase = new grpc::Method<global::gRPCGreet.Phrase, global::gRPCGreet.Phrase>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPhrase",
        __Marshaller_greet_Phrase,
        __Marshaller_greet_Phrase);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCGreet.HelloRequest, global::gRPCGreet.HelloReply> __Method_SayHello = new grpc::Method<global::gRPCGreet.HelloRequest, global::gRPCGreet.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_greet_HelloRequest,
        __Marshaller_greet_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPCGreet.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PhraseService</summary>
    [grpc::BindServiceMethod(typeof(PhraseService), "BindService")]
    public abstract partial class PhraseServiceBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPCGreet.PhrasesResponce> GetPhrases(global::gRPCGreet.PhrasesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPCGreet.Phrase> GetSpecificPhrase(global::gRPCGreet.PhraseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPCGreet.Phrase> AddPhrase(global::gRPCGreet.Phrase request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRPCGreet.HelloReply> SayHello(global::gRPCGreet.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PhraseServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetPhrases, serviceImpl.GetPhrases)
          .AddMethod(__Method_GetSpecificPhrase, serviceImpl.GetSpecificPhrase)
          .AddMethod(__Method_AddPhrase, serviceImpl.AddPhrase)
          .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PhraseServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetPhrases, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCGreet.PhrasesRequest, global::gRPCGreet.PhrasesResponce>(serviceImpl.GetPhrases));
      serviceBinder.AddMethod(__Method_GetSpecificPhrase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCGreet.PhraseRequest, global::gRPCGreet.Phrase>(serviceImpl.GetSpecificPhrase));
      serviceBinder.AddMethod(__Method_AddPhrase, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCGreet.Phrase, global::gRPCGreet.Phrase>(serviceImpl.AddPhrase));
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCGreet.HelloRequest, global::gRPCGreet.HelloReply>(serviceImpl.SayHello));
    }

  }
}
#endregion
