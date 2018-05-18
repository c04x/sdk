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

namespace Ruyi.SDK.GlobalInputDefine
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RuyiInputStateMouse : TBase
  {
    private int _RawOffset;
    private int _Value;
    private int _Timestamp;
    private int _Sequence;
    private MouseOffset _Offset;
    private bool _IsButton;

    public int RawOffset
    {
      get
      {
        return _RawOffset;
      }
      set
      {
        __isset.RawOffset = true;
        this._RawOffset = value;
      }
    }

    public int Value
    {
      get
      {
        return _Value;
      }
      set
      {
        __isset.@Value = true;
        this._Value = value;
      }
    }

    public int Timestamp
    {
      get
      {
        return _Timestamp;
      }
      set
      {
        __isset.Timestamp = true;
        this._Timestamp = value;
      }
    }

    public int Sequence
    {
      get
      {
        return _Sequence;
      }
      set
      {
        __isset.Sequence = true;
        this._Sequence = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="MouseOffset"/>
    /// </summary>
    public MouseOffset Offset
    {
      get
      {
        return _Offset;
      }
      set
      {
        __isset.Offset = true;
        this._Offset = value;
      }
    }

    public bool IsButton
    {
      get
      {
        return _IsButton;
      }
      set
      {
        __isset.IsButton = true;
        this._IsButton = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool RawOffset;
      public bool @Value;
      public bool Timestamp;
      public bool Sequence;
      public bool Offset;
      public bool IsButton;
    }

    public RuyiInputStateMouse() {
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
              if (field.Type == TType.I32) {
                RawOffset = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                Value = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                Timestamp = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I32) {
                Sequence = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I32) {
                Offset = (MouseOffset)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Bool) {
                IsButton = iprot.ReadBool();
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
        TStruct struc = new TStruct("RuyiInputStateMouse");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.RawOffset) {
          field.Name = "RawOffset";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(RawOffset);
          oprot.WriteFieldEnd();
        }
        if (__isset.@Value) {
          field.Name = "Value";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Value);
          oprot.WriteFieldEnd();
        }
        if (__isset.Timestamp) {
          field.Name = "Timestamp";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Timestamp);
          oprot.WriteFieldEnd();
        }
        if (__isset.Sequence) {
          field.Name = "Sequence";
          field.Type = TType.I32;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Sequence);
          oprot.WriteFieldEnd();
        }
        if (__isset.Offset) {
          field.Name = "Offset";
          field.Type = TType.I32;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Offset);
          oprot.WriteFieldEnd();
        }
        if (__isset.IsButton) {
          field.Name = "IsButton";
          field.Type = TType.Bool;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsButton);
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
      StringBuilder __sb = new StringBuilder("RuyiInputStateMouse(");
      bool __first = true;
      if (__isset.RawOffset) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RawOffset: ");
        __sb.Append(RawOffset);
      }
      if (__isset.@Value) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Value: ");
        __sb.Append(Value);
      }
      if (__isset.Timestamp) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Timestamp: ");
        __sb.Append(Timestamp);
      }
      if (__isset.Sequence) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Sequence: ");
        __sb.Append(Sequence);
      }
      if (__isset.Offset) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Offset: ");
        __sb.Append(Offset);
      }
      if (__isset.IsButton) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsButton: ");
        __sb.Append(IsButton);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
