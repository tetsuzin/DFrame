// <auto-generated />
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.

namespace DFrame
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::MagicOnion;
    using global::MagicOnion.Client;

    public static partial class MagicOnionInitializer
    {
        static bool isRegistered = false;

#if UNITY_2019_4_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#elif NET5_0_OR_GREATER
        [System.Runtime.CompilerServices.ModuleInitializer]
#endif
        public static void Register()
        {
            if (isRegistered) return;
            isRegistered = true;

            global::MagicOnion.Client.MagicOnionClientFactoryProvider.Default =
                (global::MagicOnion.Client.MagicOnionClientFactoryProvider.Default is global::MagicOnion.Client.ImmutableMagicOnionClientFactoryProvider immutableMagicOnionClientFactoryProvider)
                    ? immutableMagicOnionClientFactoryProvider.Add(MagicOnionGeneratedClientFactoryProvider.Instance)
                    : new global::MagicOnion.Client.ImmutableMagicOnionClientFactoryProvider(MagicOnionGeneratedClientFactoryProvider.Instance);

            global::MagicOnion.Client.StreamingHubClientFactoryProvider.Default =
                (global::MagicOnion.Client.StreamingHubClientFactoryProvider.Default is global::MagicOnion.Client.ImmutableStreamingHubClientFactoryProvider immutableStreamingHubClientFactoryProvider)
                    ? immutableStreamingHubClientFactoryProvider.Add(MagicOnionGeneratedClientFactoryProvider.Instance)
                    : new global::MagicOnion.Client.ImmutableStreamingHubClientFactoryProvider(MagicOnionGeneratedClientFactoryProvider.Instance);
        }
    }

    public partial class MagicOnionGeneratedClientFactoryProvider : global::MagicOnion.Client.IMagicOnionClientFactoryProvider, global::MagicOnion.Client.IStreamingHubClientFactoryProvider
    {
        public static MagicOnionGeneratedClientFactoryProvider Instance { get; } = new MagicOnionGeneratedClientFactoryProvider();

        MagicOnionGeneratedClientFactoryProvider() { }

        bool global::MagicOnion.Client.IMagicOnionClientFactoryProvider.TryGetFactory<T>(out global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T> factory)
            => (factory = MagicOnionClientFactoryCache<T>.Factory) != null;

        bool global::MagicOnion.Client.IStreamingHubClientFactoryProvider.TryGetFactory<TStreamingHub, TReceiver>(out global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver> factory)
            => (factory = StreamingHubClientFactoryCache<TStreamingHub, TReceiver>.Factory) != null;

        static class MagicOnionClientFactoryCache<T> where T : global::MagicOnion.IService<T>
        {
            public readonly static global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T> Factory;

            static MagicOnionClientFactoryCache()
            {
                object factory = default(global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T>);

                Factory = (global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T>)factory;
            }
        }

        static class StreamingHubClientFactoryCache<TStreamingHub, TReceiver> where TStreamingHub : global::MagicOnion.IStreamingHub<TStreamingHub, TReceiver>
        {
            public readonly static global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver> Factory;

            static StreamingHubClientFactoryCache()
            {
                object factory = default(global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver>);

                if (typeof(TStreamingHub) == typeof(global::DFrame.IControllerHub) && typeof(TReceiver) == typeof(global::DFrame.IWorkerReceiver))
                {
                    factory = ((global::MagicOnion.Client.StreamingHubClientFactoryDelegate<global::DFrame.IControllerHub, global::DFrame.IWorkerReceiver>)((a, _, b, c, d, e) => new DFrame.ControllerHubClient(a, b, c, d, e)));
                }

                Factory = (global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver>)factory;
            }
        }
    }

}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.
namespace DFrame.Resolvers
{
    using global::System;
    using global::MessagePack;
    public class MagicOnionResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new MagicOnionResolver();

        MagicOnionResolver() { }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
            => FormatterCache<T>.formatter;

        static class FormatterCache<T>
        {
            public static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                var f = MagicOnionResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }
    internal static class MagicOnionResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<global::System.Type, int> lookup;

        static MagicOnionResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(7)
            {
                {typeof(global::DFrame.WorkloadInfo[]), 0 },
                {typeof(global::MagicOnion.DynamicArgumentTuple<global::DFrame.ExecutionId, global::System.Int32, global::System.Int32, global::System.Int64, global::System.String, global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>[]>), 1 },
                {typeof(global::MagicOnion.DynamicArgumentTuple<global::DFrame.WorkloadInfo[], global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>), 2 },
                {typeof(global::System.Collections.Generic.Dictionary<global::DFrame.WorkloadId, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>), 3 },
                {typeof(global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>), 4 },
                {typeof(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>), 5 },
                {typeof(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>[]), 6 },
            };
        }
        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new global::MessagePack.Formatters.ArrayFormatter<global::DFrame.WorkloadInfo>();
                case 1: return new global::MagicOnion.DynamicArgumentTupleFormatter<global::DFrame.ExecutionId, global::System.Int32, global::System.Int32, global::System.Int64, global::System.String, global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>[]>(default(global::DFrame.ExecutionId), default(global::System.Int32), default(global::System.Int32), default(global::System.Int64), default(global::System.String), default(global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>[]));
                case 2: return new global::MagicOnion.DynamicArgumentTupleFormatter<global::DFrame.WorkloadInfo[], global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>(default(global::DFrame.WorkloadInfo[]), default(global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>));
                case 3: return new global::MessagePack.Formatters.DictionaryFormatter<global::DFrame.WorkloadId, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>();
                case 4: return new global::MessagePack.Formatters.DictionaryFormatter<global::System.String, global::System.String>();
                case 5: return new global::MessagePack.Formatters.KeyValuePairFormatter<global::System.String, global::System.String>();
                case 6: return new global::MessagePack.Formatters.ArrayFormatter<global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>>();
                default: return null;
            }
        }
    }
}
#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.


#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.

namespace DFrame
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;

    [global::MagicOnion.Ignore]
    public class ControllerHubClient : global::MagicOnion.Client.StreamingHubClientBase<global::DFrame.IControllerHub, global::DFrame.IWorkerReceiver>, global::DFrame.IControllerHub
    {
        protected override global::Grpc.Core.Method<global::System.Byte[], global::System.Byte[]> DuplexStreamingAsyncMethod { get; }

        public ControllerHubClient(global::Grpc.Core.CallInvoker callInvoker, global::System.String host, global::Grpc.Core.CallOptions options, global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider, global::MagicOnion.Client.IMagicOnionClientLogger logger)
            : base(callInvoker, host, options, serializerProvider, logger)
        {
            var marshaller = global::MagicOnion.MagicOnionMarshallers.ThroughMarshaller;
            DuplexStreamingAsyncMethod = new global::Grpc.Core.Method<global::System.Byte[], global::System.Byte[]>(global::Grpc.Core.MethodType.DuplexStreaming, "IControllerHub", "Connect", marshaller, marshaller);
        }

        public global::System.Threading.Tasks.Task ConnectAsync(global::DFrame.WorkloadInfo[] workloads, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> metadata)
            => base.WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::DFrame.WorkloadInfo[], global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>, global::MessagePack.Nil>(2012341859, new global::MagicOnion.DynamicArgumentTuple<global::DFrame.WorkloadInfo[], global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>(workloads, metadata));
        public global::System.Threading.Tasks.Task CreateWorkloadCompleteAsync(global::DFrame.ExecutionId executionId)
            => base.WriteMessageWithResponseAsync<global::DFrame.ExecutionId, global::MessagePack.Nil>(-933234259, executionId);
        public global::System.Threading.Tasks.Task ReportProgressAsync(global::DFrame.ExecuteResult result)
            => base.WriteMessageWithResponseAsync<global::DFrame.ExecuteResult, global::MessagePack.Nil>(-2138341752, result);
        public global::System.Threading.Tasks.Task ReportProgressBatchedAsync(global::DFrame.BatchedExecuteResult result)
            => base.WriteMessageWithResponseAsync<global::DFrame.BatchedExecuteResult, global::MessagePack.Nil>(1635120551, result);
        public global::System.Threading.Tasks.Task ExecuteCompleteAsync(global::System.Collections.Generic.Dictionary<global::DFrame.WorkloadId, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>> results)
            => base.WriteMessageWithResponseAsync<global::System.Collections.Generic.Dictionary<global::DFrame.WorkloadId, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>, global::MessagePack.Nil>(244451313, results);
        public global::System.Threading.Tasks.Task TeardownCompleteAsync()
            => base.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-1034933934, global::MessagePack.Nil.Default);

        public global::DFrame.IControllerHub FireAndForget()
            => new FireAndForgetClient(this);

        [global::MagicOnion.Ignore]
        class FireAndForgetClient : global::DFrame.IControllerHub
        {
            readonly ControllerHubClient parent;

            public FireAndForgetClient(ControllerHubClient parent)
                => this.parent = parent;

            public global::DFrame.IControllerHub FireAndForget() => this;
            public global::System.Threading.Tasks.Task DisposeAsync() => throw new global::System.NotSupportedException();
            public global::System.Threading.Tasks.Task WaitForDisconnect() => throw new global::System.NotSupportedException();

            public global::System.Threading.Tasks.Task ConnectAsync(global::DFrame.WorkloadInfo[] workloads, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> metadata)
                => parent.WriteMessageFireAndForgetAsync<global::MagicOnion.DynamicArgumentTuple<global::DFrame.WorkloadInfo[], global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>, global::MessagePack.Nil>(2012341859, new global::MagicOnion.DynamicArgumentTuple<global::DFrame.WorkloadInfo[], global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>(workloads, metadata));
            public global::System.Threading.Tasks.Task CreateWorkloadCompleteAsync(global::DFrame.ExecutionId executionId)
                => parent.WriteMessageFireAndForgetAsync<global::DFrame.ExecutionId, global::MessagePack.Nil>(-933234259, executionId);
            public global::System.Threading.Tasks.Task ReportProgressAsync(global::DFrame.ExecuteResult result)
                => parent.WriteMessageFireAndForgetAsync<global::DFrame.ExecuteResult, global::MessagePack.Nil>(-2138341752, result);
            public global::System.Threading.Tasks.Task ReportProgressBatchedAsync(global::DFrame.BatchedExecuteResult result)
                => parent.WriteMessageFireAndForgetAsync<global::DFrame.BatchedExecuteResult, global::MessagePack.Nil>(1635120551, result);
            public global::System.Threading.Tasks.Task ExecuteCompleteAsync(global::System.Collections.Generic.Dictionary<global::DFrame.WorkloadId, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>> results)
                => parent.WriteMessageFireAndForgetAsync<global::System.Collections.Generic.Dictionary<global::DFrame.WorkloadId, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>>, global::MessagePack.Nil>(244451313, results);
            public global::System.Threading.Tasks.Task TeardownCompleteAsync()
                => parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-1034933934, global::MessagePack.Nil.Default);

        }

        protected override void OnBroadcastEvent(global::System.Int32 methodId, global::System.ArraySegment<global::System.Byte> data)
        {
            switch (methodId)
            {
                case 984740550: // Void CreateWorkloadAndSetup(global::DFrame.ExecutionId executionId, global::System.Int32 createCount, global::System.Int32 concurrency, global::System.Int64 totalRequestCount, global::System.String workloadName, global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>[] parameters)
                    {
                        var value = base.Deserialize<global::MagicOnion.DynamicArgumentTuple<CommandMode, global::DFrame.ExecutionId, global::System.Int32, global::System.Int32, global::System.Int64, global::System.String, global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.String>[]>>(data);
                        receiver.CreateWorkloadAndSetup(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7);
                    }
                    break;
                case 650159416: // Void Execute(global::System.Int64[] executeCount)
                    {
                        var value = base.Deserialize<global::System.Int64[]>(data);
                        receiver.Execute(value);
                    }
                    break;
                case 1266644741: // Void Stop()
                    {
                        var value = base.Deserialize<global::MessagePack.Nil>(data);
                        receiver.Stop();
                    }
                    break;
                case -9051375: // Void Teardown()
                    {
                        var value = base.Deserialize<global::MessagePack.Nil>(data);
                        receiver.Teardown();
                    }
                    break;
            }
        }

        protected override void OnResponseEvent(global::System.Int32 methodId, global::System.Object taskCompletionSource, global::System.ArraySegment<global::System.Byte> data)
        {
            switch (methodId)
            {
                case 2012341859: // Task ConnectAsync(global::DFrame.WorkloadInfo[] workloads, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> metadata)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case -933234259: // Task CreateWorkloadCompleteAsync(global::DFrame.ExecutionId executionId)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case -2138341752: // Task ReportProgressAsync(global::DFrame.ExecuteResult result)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case 1635120551: // Task ReportProgressBatchedAsync(global::DFrame.BatchedExecuteResult result)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case 244451313: // Task ExecuteCompleteAsync(global::System.Collections.Generic.Dictionary<global::DFrame.WorkloadId, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String>> results)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case -1034933934: // Task TeardownCompleteAsync()
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
            }
        }

    }
}


