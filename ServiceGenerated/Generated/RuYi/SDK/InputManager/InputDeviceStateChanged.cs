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
  public partial class InputDeviceStateChanged : TBase
  {
    private InputDeviceEventHeader _header;
    private InputDeviceStateChangedX360 _x360;
    private InputDeviceStateChangedGamepad _dgamepad;
    private InputDeviceStateChangedJoystick _djoystick;
    private InputDeviceStateChangedKeyboard _dkeyboard;
    private InputDeviceStateChangedMouse _dmouse;
    private InputDeviceStateChangedRuyiController _ruyicontroller;

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

    public InputDeviceStateChangedX360 X360
    {
      get
      {
        return _x360;
      }
      set
      {
        __isset.x360 = true;
        this._x360 = value;
      }
    }

    public InputDeviceStateChangedGamepad Dgamepad
    {
      get
      {
        return _dgamepad;
      }
      set
      {
        __isset.dgamepad = true;
        this._dgamepad = value;
      }
    }

    public InputDeviceStateChangedJoystick Djoystick
    {
      get
      {
        return _djoystick;
      }
      set
      {
        __isset.djoystick = true;
        this._djoystick = value;
      }
    }

    public InputDeviceStateChangedKeyboard Dkeyboard
    {
      get
      {
        return _dkeyboard;
      }
      set
      {
        __isset.dkeyboard = true;
        this._dkeyboard = value;
      }
    }

    public InputDeviceStateChangedMouse Dmouse
    {
      get
      {
        return _dmouse;
      }
      set
      {
        __isset.dmouse = true;
        this._dmouse = value;
      }
    }

    public InputDeviceStateChangedRuyiController Ruyicontroller
    {
      get
      {
        return _ruyicontroller;
      }
      set
      {
        __isset.ruyicontroller = true;
        this._ruyicontroller = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool header;
      public bool x360;
      public bool dgamepad;
      public bool djoystick;
      public bool dkeyboard;
      public bool dmouse;
      public bool ruyicontroller;
    }

    public InputDeviceStateChanged() {
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
              if (field.Type == TType.Struct) {
                X360 = new InputDeviceStateChangedX360();
                X360.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                Dgamepad = new InputDeviceStateChangedGamepad();
                Dgamepad.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Struct) {
                Djoystick = new InputDeviceStateChangedJoystick();
                Djoystick.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Struct) {
                Dkeyboard = new InputDeviceStateChangedKeyboard();
                Dkeyboard.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Struct) {
                Dmouse = new InputDeviceStateChangedMouse();
                Dmouse.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Struct) {
                Ruyicontroller = new InputDeviceStateChangedRuyiController();
                Ruyicontroller.Read(iprot);
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
        TStruct struc = new TStruct("InputDeviceStateChanged");
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
        if (X360 != null && __isset.x360) {
          field.Name = "x360";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          X360.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Dgamepad != null && __isset.dgamepad) {
          field.Name = "dgamepad";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          Dgamepad.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Djoystick != null && __isset.djoystick) {
          field.Name = "djoystick";
          field.Type = TType.Struct;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          Djoystick.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Dkeyboard != null && __isset.dkeyboard) {
          field.Name = "dkeyboard";
          field.Type = TType.Struct;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          Dkeyboard.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Dmouse != null && __isset.dmouse) {
          field.Name = "dmouse";
          field.Type = TType.Struct;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          Dmouse.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Ruyicontroller != null && __isset.ruyicontroller) {
          field.Name = "ruyicontroller";
          field.Type = TType.Struct;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          Ruyicontroller.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("InputDeviceStateChanged(");
      bool __first = true;
      if (Header != null && __isset.header) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Header: ");
        __sb.Append(Header== null ? "<null>" : Header.ToString());
      }
      if (X360 != null && __isset.x360) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("X360: ");
        __sb.Append(X360== null ? "<null>" : X360.ToString());
      }
      if (Dgamepad != null && __isset.dgamepad) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dgamepad: ");
        __sb.Append(Dgamepad== null ? "<null>" : Dgamepad.ToString());
      }
      if (Djoystick != null && __isset.djoystick) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Djoystick: ");
        __sb.Append(Djoystick== null ? "<null>" : Djoystick.ToString());
      }
      if (Dkeyboard != null && __isset.dkeyboard) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dkeyboard: ");
        __sb.Append(Dkeyboard== null ? "<null>" : Dkeyboard.ToString());
      }
      if (Dmouse != null && __isset.dmouse) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dmouse: ");
        __sb.Append(Dmouse== null ? "<null>" : Dmouse.ToString());
      }
      if (Ruyicontroller != null && __isset.ruyicontroller) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ruyicontroller: ");
        __sb.Append(Ruyicontroller== null ? "<null>" : Ruyicontroller.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
