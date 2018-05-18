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

namespace Ruyi.SDK.GlobalInputDefine
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RuyiInputStateRuyiController : TBase
  {
    private long _PacketId;
    private int _ChannelId;
    private string _DeviceId;
    private int _KeyPress;
    private sbyte _AnalogL2;
    private sbyte _AnalogR2;
    private sbyte _AnalogLeftJoyX;
    private sbyte _AnalogLeftJoyY;
    private sbyte _AnalogRightJoyX;
    private sbyte _AnalogRightJoyY;

    public long PacketId
    {
      get
      {
        return _PacketId;
      }
      set
      {
        __isset.PacketId = true;
        this._PacketId = value;
      }
    }

    public int ChannelId
    {
      get
      {
        return _ChannelId;
      }
      set
      {
        __isset.ChannelId = true;
        this._ChannelId = value;
      }
    }

    public string DeviceId
    {
      get
      {
        return _DeviceId;
      }
      set
      {
        __isset.DeviceId = true;
        this._DeviceId = value;
      }
    }

    public int KeyPress
    {
      get
      {
        return _KeyPress;
      }
      set
      {
        __isset.KeyPress = true;
        this._KeyPress = value;
      }
    }

    public sbyte AnalogL2
    {
      get
      {
        return _AnalogL2;
      }
      set
      {
        __isset.AnalogL2 = true;
        this._AnalogL2 = value;
      }
    }

    public sbyte AnalogR2
    {
      get
      {
        return _AnalogR2;
      }
      set
      {
        __isset.AnalogR2 = true;
        this._AnalogR2 = value;
      }
    }

    public sbyte AnalogLeftJoyX
    {
      get
      {
        return _AnalogLeftJoyX;
      }
      set
      {
        __isset.AnalogLeftJoyX = true;
        this._AnalogLeftJoyX = value;
      }
    }

    public sbyte AnalogLeftJoyY
    {
      get
      {
        return _AnalogLeftJoyY;
      }
      set
      {
        __isset.AnalogLeftJoyY = true;
        this._AnalogLeftJoyY = value;
      }
    }

    public sbyte AnalogRightJoyX
    {
      get
      {
        return _AnalogRightJoyX;
      }
      set
      {
        __isset.AnalogRightJoyX = true;
        this._AnalogRightJoyX = value;
      }
    }

    public sbyte AnalogRightJoyY
    {
      get
      {
        return _AnalogRightJoyY;
      }
      set
      {
        __isset.AnalogRightJoyY = true;
        this._AnalogRightJoyY = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool PacketId;
      public bool ChannelId;
      public bool DeviceId;
      public bool KeyPress;
      public bool AnalogL2;
      public bool AnalogR2;
      public bool AnalogLeftJoyX;
      public bool AnalogLeftJoyY;
      public bool AnalogRightJoyX;
      public bool AnalogRightJoyY;
    }

    public RuyiInputStateRuyiController() {
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
              if (field.Type == TType.I64) {
                PacketId = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                ChannelId = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                DeviceId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I32) {
                KeyPress = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Byte) {
                AnalogL2 = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Byte) {
                AnalogR2 = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Byte) {
                AnalogLeftJoyX = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Byte) {
                AnalogLeftJoyY = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Byte) {
                AnalogRightJoyX = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.Byte) {
                AnalogRightJoyY = iprot.ReadByte();
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
        TStruct struc = new TStruct("RuyiInputStateRuyiController");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.PacketId) {
          field.Name = "PacketId";
          field.Type = TType.I64;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(PacketId);
          oprot.WriteFieldEnd();
        }
        if (__isset.ChannelId) {
          field.Name = "ChannelId";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(ChannelId);
          oprot.WriteFieldEnd();
        }
        if (DeviceId != null && __isset.DeviceId) {
          field.Name = "DeviceId";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(DeviceId);
          oprot.WriteFieldEnd();
        }
        if (__isset.KeyPress) {
          field.Name = "KeyPress";
          field.Type = TType.I32;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(KeyPress);
          oprot.WriteFieldEnd();
        }
        if (__isset.AnalogL2) {
          field.Name = "AnalogL2";
          field.Type = TType.Byte;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(AnalogL2);
          oprot.WriteFieldEnd();
        }
        if (__isset.AnalogR2) {
          field.Name = "AnalogR2";
          field.Type = TType.Byte;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(AnalogR2);
          oprot.WriteFieldEnd();
        }
        if (__isset.AnalogLeftJoyX) {
          field.Name = "AnalogLeftJoyX";
          field.Type = TType.Byte;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(AnalogLeftJoyX);
          oprot.WriteFieldEnd();
        }
        if (__isset.AnalogLeftJoyY) {
          field.Name = "AnalogLeftJoyY";
          field.Type = TType.Byte;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(AnalogLeftJoyY);
          oprot.WriteFieldEnd();
        }
        if (__isset.AnalogRightJoyX) {
          field.Name = "AnalogRightJoyX";
          field.Type = TType.Byte;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(AnalogRightJoyX);
          oprot.WriteFieldEnd();
        }
        if (__isset.AnalogRightJoyY) {
          field.Name = "AnalogRightJoyY";
          field.Type = TType.Byte;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(AnalogRightJoyY);
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
      StringBuilder __sb = new StringBuilder("RuyiInputStateRuyiController(");
      bool __first = true;
      if (__isset.PacketId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PacketId: ");
        __sb.Append(PacketId);
      }
      if (__isset.ChannelId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ChannelId: ");
        __sb.Append(ChannelId);
      }
      if (DeviceId != null && __isset.DeviceId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceId: ");
        __sb.Append(DeviceId);
      }
      if (__isset.KeyPress) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("KeyPress: ");
        __sb.Append(KeyPress);
      }
      if (__isset.AnalogL2) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AnalogL2: ");
        __sb.Append(AnalogL2);
      }
      if (__isset.AnalogR2) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AnalogR2: ");
        __sb.Append(AnalogR2);
      }
      if (__isset.AnalogLeftJoyX) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AnalogLeftJoyX: ");
        __sb.Append(AnalogLeftJoyX);
      }
      if (__isset.AnalogLeftJoyY) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AnalogLeftJoyY: ");
        __sb.Append(AnalogLeftJoyY);
      }
      if (__isset.AnalogRightJoyX) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AnalogRightJoyX: ");
        __sb.Append(AnalogRightJoyX);
      }
      if (__isset.AnalogRightJoyY) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AnalogRightJoyY: ");
        __sb.Append(AnalogRightJoyY);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
