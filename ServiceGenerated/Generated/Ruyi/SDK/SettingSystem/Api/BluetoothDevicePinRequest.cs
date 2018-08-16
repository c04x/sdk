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

namespace Ruyi.SDK.SettingSystem.Api
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class BluetoothDevicePinRequest : TBase
  {
    private string _DeviceName;
    private string _Pin;

    public string DeviceName
    {
      get
      {
        return _DeviceName;
      }
      set
      {
        __isset.DeviceName = true;
        this._DeviceName = value;
      }
    }

    public string Pin
    {
      get
      {
        return _Pin;
      }
      set
      {
        __isset.Pin = true;
        this._Pin = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool DeviceName;
      public bool Pin;
    }

    public BluetoothDevicePinRequest() {
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
              if (field.Type == TType.String) {
                DeviceName = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Pin = iprot.ReadString();
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
        TStruct struc = new TStruct("BluetoothDevicePinRequest");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (DeviceName != null && __isset.DeviceName) {
          field.Name = "DeviceName";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(DeviceName);
          oprot.WriteFieldEnd();
        }
        if (Pin != null && __isset.Pin) {
          field.Name = "Pin";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Pin);
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
      StringBuilder __sb = new StringBuilder("BluetoothDevicePinRequest(");
      bool __first = true;
      if (DeviceName != null && __isset.DeviceName) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceName: ");
        __sb.Append(DeviceName);
      }
      if (Pin != null && __isset.Pin) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Pin: ");
        __sb.Append(Pin);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}