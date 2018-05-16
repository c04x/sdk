/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.MediaService
{
  public partial class MediaService {
    public interface ISync {
      int SendMsg(Ruyi.SDK.MediaService.RequestMsg request, bool broadcast);
    }

    public interface Iface : ISync {
      #if SILVERLIGHT
      IAsyncResult Begin_SendMsg(AsyncCallback callback, object state, Ruyi.SDK.MediaService.RequestMsg request, bool broadcast);
      int End_SendMsg(IAsyncResult asyncResult);
      #endif
    }

    public class Client : IDisposable, Iface {
      public Client(TProtocol prot) : this(prot, prot)
      {
      }

      public Client(TProtocol iprot, TProtocol oprot)
      {
        iprot_ = iprot;
        oprot_ = oprot;
      }

      protected TProtocol iprot_;
      protected TProtocol oprot_;
      protected int seqid_;

      public TProtocol InputProtocol
      {
        get { return iprot_; }
      }
      public TProtocol OutputProtocol
      {
        get { return oprot_; }
      }


      #region " IDisposable Support "
      private bool _IsDisposed;

      // IDisposable
      public void Dispose()
      {
        Dispose(true);
      }
      

      protected virtual void Dispose(bool disposing)
      {
        if (!_IsDisposed)
        {
          if (disposing)
          {
            if (iprot_ != null)
            {
              ((IDisposable)iprot_).Dispose();
            }
            if (oprot_ != null)
            {
              ((IDisposable)oprot_).Dispose();
            }
          }
        }
        _IsDisposed = true;
      }
      #endregion


      
      #if SILVERLIGHT
      public IAsyncResult Begin_SendMsg(AsyncCallback callback, object state, Ruyi.SDK.MediaService.RequestMsg request, bool broadcast)
      {
        return send_SendMsg(callback, state, request, broadcast);
      }

      public int End_SendMsg(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_SendMsg();
      }

      #endif

      public int SendMsg(Ruyi.SDK.MediaService.RequestMsg request, bool broadcast)
      {
        #if !SILVERLIGHT
        send_SendMsg(request, broadcast);
        return recv_SendMsg();

        #else
        var asyncResult = Begin_SendMsg(null, null, request, broadcast);
        return End_SendMsg(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_SendMsg(AsyncCallback callback, object state, Ruyi.SDK.MediaService.RequestMsg request, bool broadcast)
      #else
      public void send_SendMsg(Ruyi.SDK.MediaService.RequestMsg request, bool broadcast)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("SendMsg", TMessageType.Call, seqid_));
        SendMsg_args args = new SendMsg_args();
        args.Request = request;
        args.Broadcast = broadcast;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public int recv_SendMsg()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        SendMsg_result result = new SendMsg_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "SendMsg failed: unknown result");
      }

    }
    public class Processor : TProcessor {
      public Processor(ISync iface)
      {
        iface_ = iface;
        processMap_["SendMsg"] = SendMsg_Process;
      }

      protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
      private ISync iface_;
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public bool Process(TProtocol iprot, TProtocol oprot)
      {
        try
        {
          TMessage msg = iprot.ReadMessageBegin();
          ProcessFunction fn;
          processMap_.TryGetValue(msg.Name, out fn);
          if (fn == null) {
            TProtocolUtil.Skip(iprot, TType.Struct);
            iprot.ReadMessageEnd();
            TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
            x.Write(oprot);
            oprot.WriteMessageEnd();
            oprot.Transport.Flush();
            return true;
          }
          fn(msg.SeqID, iprot, oprot);
        }
        catch (IOException)
        {
          return false;
        }
        return true;
      }

      public void SendMsg_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        SendMsg_args args = new SendMsg_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        SendMsg_result result = new SendMsg_result();
        try
        {
          result.Success = iface_.SendMsg(args.Request, args.Broadcast);
          oprot.WriteMessageBegin(new TMessage("SendMsg", TMessageType.Reply, seqid)); 
          result.Write(oprot);
        }
        catch (TTransportException)
        {
          throw;
        }
        catch (Exception ex)
        {
          Console.Error.WriteLine("Error occurred in processor:");
          Console.Error.WriteLine(ex.ToString());
          TApplicationException x = new TApplicationException        (TApplicationException.ExceptionType.InternalError," Internal error.");
          oprot.WriteMessageBegin(new TMessage("SendMsg", TMessageType.Exception, seqid));
          x.Write(oprot);
        }
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class SendMsg_args : TBase
    {
      private Ruyi.SDK.MediaService.RequestMsg _request;
      private bool _broadcast;

      public Ruyi.SDK.MediaService.RequestMsg Request
      {
        get
        {
          return _request;
        }
        set
        {
          __isset.request = true;
          this._request = value;
        }
      }

      public bool Broadcast
      {
        get
        {
          return _broadcast;
        }
        set
        {
          __isset.broadcast = true;
          this._broadcast = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool request;
        public bool broadcast;
      }

      public SendMsg_args() {
      }

      public void Read (TProtocol iprot)
      {
        iprot.IncrementRecursionDepth();
        try
        {
          TField field;
          iprot.ReadStructBegin();
          while (true)
          {
            field = iprot.ReadFieldBegin();
            if (field.Type == TType.Stop) { 
              break;
            }
            switch (field.ID)
            {
              case 1:
                if (field.Type == TType.Struct) {
                  Request = new Ruyi.SDK.MediaService.RequestMsg();
                  Request.Read(iprot);
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              case 2:
                if (field.Type == TType.Bool) {
                  Broadcast = iprot.ReadBool();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              default: 
                TProtocolUtil.Skip(iprot, field.Type);
                break;
            }
            iprot.ReadFieldEnd();
          }
          iprot.ReadStructEnd();
        }
        finally
        {
          iprot.DecrementRecursionDepth();
        }
      }

      public void Write(TProtocol oprot) {
        oprot.IncrementRecursionDepth();
        try
        {
          TStruct struc = new TStruct("SendMsg_args");
          oprot.WriteStructBegin(struc);
          TField field = new TField();
          if (Request != null && __isset.request) {
            field.Name = "request";
            field.Type = TType.Struct;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            Request.Write(oprot);
            oprot.WriteFieldEnd();
          }
          if (__isset.broadcast) {
            field.Name = "broadcast";
            field.Type = TType.Bool;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteBool(Broadcast);
            oprot.WriteFieldEnd();
          }
          oprot.WriteFieldStop();
          oprot.WriteStructEnd();
        }
        finally
        {
          oprot.DecrementRecursionDepth();
        }
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("SendMsg_args(");
        bool __first = true;
        if (Request != null && __isset.request) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Request: ");
          __sb.Append(Request== null ? "<null>" : Request.ToString());
        }
        if (__isset.broadcast) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Broadcast: ");
          __sb.Append(Broadcast);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class SendMsg_result : TBase
    {
      private int _success;

      public int Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public SendMsg_result() {
      }

      public void Read (TProtocol iprot)
      {
        iprot.IncrementRecursionDepth();
        try
        {
          TField field;
          iprot.ReadStructBegin();
          while (true)
          {
            field = iprot.ReadFieldBegin();
            if (field.Type == TType.Stop) { 
              break;
            }
            switch (field.ID)
            {
              case 0:
                if (field.Type == TType.I32) {
                  Success = iprot.ReadI32();
                } else { 
                  TProtocolUtil.Skip(iprot, field.Type);
                }
                break;
              default: 
                TProtocolUtil.Skip(iprot, field.Type);
                break;
            }
            iprot.ReadFieldEnd();
          }
          iprot.ReadStructEnd();
        }
        finally
        {
          iprot.DecrementRecursionDepth();
        }
      }

      public void Write(TProtocol oprot) {
        oprot.IncrementRecursionDepth();
        try
        {
          TStruct struc = new TStruct("SendMsg_result");
          oprot.WriteStructBegin(struc);
          TField field = new TField();

          if (this.__isset.success) {
            field.Name = "Success";
            field.Type = TType.I32;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            oprot.WriteI32(Success);
            oprot.WriteFieldEnd();
          }
          oprot.WriteFieldStop();
          oprot.WriteStructEnd();
        }
        finally
        {
          oprot.DecrementRecursionDepth();
        }
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("SendMsg_result(");
        bool __first = true;
        if (__isset.success) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Success: ");
          __sb.Append(Success);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }

  }
}
