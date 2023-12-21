// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/basket.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace eShopLite.GrpcBasket {
  public static partial class Basket
  {
    static readonly string __ServiceName = "BasketApi.Basket";

    static readonly grpc::Marshaller<global::eShopLite.GrpcBasket.BasketRequest> __Marshaller_BasketApi_BasketRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::eShopLite.GrpcBasket.BasketRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::eShopLite.GrpcBasket.CustomerBasketResponse> __Marshaller_BasketApi_CustomerBasketResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::eShopLite.GrpcBasket.CustomerBasketResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::eShopLite.GrpcBasket.CustomerBasketRequest> __Marshaller_BasketApi_CustomerBasketRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::eShopLite.GrpcBasket.CustomerBasketRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::eShopLite.GrpcBasket.CheckoutCustomerBasketRequest> __Marshaller_BasketApi_CheckoutCustomerBasketRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::eShopLite.GrpcBasket.CheckoutCustomerBasketRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::eShopLite.GrpcBasket.CheckoutCustomerBasketResponse> __Marshaller_BasketApi_CheckoutCustomerBasketResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::eShopLite.GrpcBasket.CheckoutCustomerBasketResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::eShopLite.GrpcBasket.DeleteCustomerBasketRequest> __Marshaller_BasketApi_DeleteCustomerBasketRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::eShopLite.GrpcBasket.DeleteCustomerBasketRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::eShopLite.GrpcBasket.DeleteCustomerBasketResponse> __Marshaller_BasketApi_DeleteCustomerBasketResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::eShopLite.GrpcBasket.DeleteCustomerBasketResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::eShopLite.GrpcBasket.BasketRequest, global::eShopLite.GrpcBasket.CustomerBasketResponse> __Method_GetBasketById = new grpc::Method<global::eShopLite.GrpcBasket.BasketRequest, global::eShopLite.GrpcBasket.CustomerBasketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBasketById",
        __Marshaller_BasketApi_BasketRequest,
        __Marshaller_BasketApi_CustomerBasketResponse);

    static readonly grpc::Method<global::eShopLite.GrpcBasket.CustomerBasketRequest, global::eShopLite.GrpcBasket.CustomerBasketResponse> __Method_UpdateBasket = new grpc::Method<global::eShopLite.GrpcBasket.CustomerBasketRequest, global::eShopLite.GrpcBasket.CustomerBasketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBasket",
        __Marshaller_BasketApi_CustomerBasketRequest,
        __Marshaller_BasketApi_CustomerBasketResponse);

    static readonly grpc::Method<global::eShopLite.GrpcBasket.CheckoutCustomerBasketRequest, global::eShopLite.GrpcBasket.CheckoutCustomerBasketResponse> __Method_CheckoutBasket = new grpc::Method<global::eShopLite.GrpcBasket.CheckoutCustomerBasketRequest, global::eShopLite.GrpcBasket.CheckoutCustomerBasketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckoutBasket",
        __Marshaller_BasketApi_CheckoutCustomerBasketRequest,
        __Marshaller_BasketApi_CheckoutCustomerBasketResponse);

    static readonly grpc::Method<global::eShopLite.GrpcBasket.DeleteCustomerBasketRequest, global::eShopLite.GrpcBasket.DeleteCustomerBasketResponse> __Method_DeleteBasket = new grpc::Method<global::eShopLite.GrpcBasket.DeleteCustomerBasketRequest, global::eShopLite.GrpcBasket.DeleteCustomerBasketResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBasket",
        __Marshaller_BasketApi_DeleteCustomerBasketRequest,
        __Marshaller_BasketApi_DeleteCustomerBasketResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::eShopLite.GrpcBasket.BasketReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Basket</summary>
    [grpc::BindServiceMethod(typeof(Basket), "BindService")]
    public abstract partial class BasketBase
    {
      public virtual global::System.Threading.Tasks.Task<global::eShopLite.GrpcBasket.CustomerBasketResponse> GetBasketById(global::eShopLite.GrpcBasket.BasketRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::eShopLite.GrpcBasket.CustomerBasketResponse> UpdateBasket(global::eShopLite.GrpcBasket.CustomerBasketRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::eShopLite.GrpcBasket.CheckoutCustomerBasketResponse> CheckoutBasket(global::eShopLite.GrpcBasket.CheckoutCustomerBasketRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::eShopLite.GrpcBasket.DeleteCustomerBasketResponse> DeleteBasket(global::eShopLite.GrpcBasket.DeleteCustomerBasketRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BasketBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetBasketById, serviceImpl.GetBasketById)
          .AddMethod(__Method_UpdateBasket, serviceImpl.UpdateBasket)
          .AddMethod(__Method_CheckoutBasket, serviceImpl.CheckoutBasket)
          .AddMethod(__Method_DeleteBasket, serviceImpl.DeleteBasket).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BasketBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetBasketById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::eShopLite.GrpcBasket.BasketRequest, global::eShopLite.GrpcBasket.CustomerBasketResponse>(serviceImpl.GetBasketById));
      serviceBinder.AddMethod(__Method_UpdateBasket, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::eShopLite.GrpcBasket.CustomerBasketRequest, global::eShopLite.GrpcBasket.CustomerBasketResponse>(serviceImpl.UpdateBasket));
      serviceBinder.AddMethod(__Method_CheckoutBasket, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::eShopLite.GrpcBasket.CheckoutCustomerBasketRequest, global::eShopLite.GrpcBasket.CheckoutCustomerBasketResponse>(serviceImpl.CheckoutBasket));
      serviceBinder.AddMethod(__Method_DeleteBasket, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::eShopLite.GrpcBasket.DeleteCustomerBasketRequest, global::eShopLite.GrpcBasket.DeleteCustomerBasketResponse>(serviceImpl.DeleteBasket));
    }

  }
}
#endregion
