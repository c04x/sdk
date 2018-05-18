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
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.InputManager
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class InputDeviceConnectionChanged : TBase
  {
    private InputDeviceEventHeader _header;
    private bool _isConnected;

    public InputDeviceEventHeader Header
    {
      get
      {
        return _header;
      }
      set
      {
        __isset.header = true;
        this._header = value;
      }
    }

    public bool IsConnected
    {
      get
      {
        return _isConnected;
      }
      set
      {
        __isset.isConnected = true;
        this._isConnected = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool header;
      public bool isConnected;
    }

    public InputDeviceConnectionChanged() {
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
                Header = new InputDeviceEventHeader();
                Header.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Bool) {
                IsConnected = iprot.ReadBool();
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
        TStruct struc = new TStruct("InputDeviceConnectionChanged");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Header != null && __isset.header) {
          field.Name = "header";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Header.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.isConnected) {
          field.Name = "isConnected";
          field.Type = TType.Bool;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsConnected);
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
      StringBuilder __sb = new StringBuilder("InputDeviceConnectionChanged(");
      bool __first = true;
      if (Header != null && __isset.header) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Header: ");
        __sb.Append(Header== null ? "<null>" : Header.ToString());
      }
      if (__isset.isConnected) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsConnected: ");
        __sb.Append(IsConnected);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
