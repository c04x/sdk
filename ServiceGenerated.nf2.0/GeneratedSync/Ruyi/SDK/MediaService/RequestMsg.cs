/**
 * Autogenerated by Thrift Compiler (0.11.0)
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

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RequestMsg : TBase
  {
    private PlayMsg _Play;
    private PauseMsg _Pause;
    private StopMsg _Stop;
    private AddPathMsg _AddPath;
    private RemovePathMsg _RemovePath;
    private QueryMsg _Query;

    public PlayMsg Play
    {
      get
      {
        return _Play;
      }
      set
      {
        __isset.Play = true;
        this._Play = value;
      }
    }

    public PauseMsg Pause
    {
      get
      {
        return _Pause;
      }
      set
      {
        __isset.Pause = true;
        this._Pause = value;
      }
    }

    public StopMsg Stop
    {
      get
      {
        return _Stop;
      }
      set
      {
        __isset.Stop = true;
        this._Stop = value;
      }
    }

    public AddPathMsg AddPath
    {
      get
      {
        return _AddPath;
      }
      set
      {
        __isset.AddPath = true;
        this._AddPath = value;
      }
    }

    public RemovePathMsg RemovePath
    {
      get
      {
        return _RemovePath;
      }
      set
      {
        __isset.RemovePath = true;
        this._RemovePath = value;
      }
    }

    public QueryMsg Query
    {
      get
      {
        return _Query;
      }
      set
      {
        __isset.Query = true;
        this._Query = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool Play;
      public bool Pause;
      public bool Stop;
      public bool AddPath;
      public bool RemovePath;
      public bool Query;
    }

    public RequestMsg() {
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
                Play = new PlayMsg();
                Play.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                Pause = new PauseMsg();
                Pause.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                Stop = new StopMsg();
                Stop.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Struct) {
                AddPath = new AddPathMsg();
                AddPath.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Struct) {
                RemovePath = new RemovePathMsg();
                RemovePath.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Struct) {
                Query = new QueryMsg();
                Query.Read(iprot);
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
        TStruct struc = new TStruct("RequestMsg");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Play != null && __isset.Play) {
          field.Name = "Play";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Play.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Pause != null && __isset.Pause) {
          field.Name = "Pause";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          Pause.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Stop != null && __isset.Stop) {
          field.Name = "Stop";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          Stop.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (AddPath != null && __isset.AddPath) {
          field.Name = "AddPath";
          field.Type = TType.Struct;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          AddPath.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (RemovePath != null && __isset.RemovePath) {
          field.Name = "RemovePath";
          field.Type = TType.Struct;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          RemovePath.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Query != null && __isset.Query) {
          field.Name = "Query";
          field.Type = TType.Struct;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          Query.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("RequestMsg(");
      bool __first = true;
      if (Play != null && __isset.Play) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Play: ");
        __sb.Append(Play== null ? "<null>" : Play.ToString());
      }
      if (Pause != null && __isset.Pause) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Pause: ");
        __sb.Append(Pause== null ? "<null>" : Pause.ToString());
      }
      if (Stop != null && __isset.Stop) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Stop: ");
        __sb.Append(Stop== null ? "<null>" : Stop.ToString());
      }
      if (AddPath != null && __isset.AddPath) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AddPath: ");
        __sb.Append(AddPath== null ? "<null>" : AddPath.ToString());
      }
      if (RemovePath != null && __isset.RemovePath) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RemovePath: ");
        __sb.Append(RemovePath== null ? "<null>" : RemovePath.ToString());
      }
      if (Query != null && __isset.Query) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Query: ");
        __sb.Append(Query== null ? "<null>" : Query.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
