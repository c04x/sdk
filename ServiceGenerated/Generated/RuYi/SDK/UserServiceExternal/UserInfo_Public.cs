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

namespace Ruyi.SDK.UserServiceExternal
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class UserInfo_Public : TBase
  {
    private string _userId;
    private string _nickname;
    private string _portrait;
    private UserGender _gender;

    public string UserId
    {
      get
      {
        return _userId;
      }
      set
      {
        __isset.userId = true;
        this._userId = value;
      }
    }

    public string Nickname
    {
      get
      {
        return _nickname;
      }
      set
      {
        __isset.nickname = true;
        this._nickname = value;
      }
    }

    public string Portrait
    {
      get
      {
        return _portrait;
      }
      set
      {
        __isset.portrait = true;
        this._portrait = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="UserGender"/>
    /// </summary>
    public UserGender Gender
    {
      get
      {
        return _gender;
      }
      set
      {
        __isset.gender = true;
        this._gender = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool userId;
      public bool nickname;
      public bool portrait;
      public bool gender;
    }

    public UserInfo_Public() {
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
                UserId = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Nickname = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Portrait = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I32) {
                Gender = (UserGender)iprot.ReadI32();
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
        TStruct struc = new TStruct("UserInfo_Public");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (UserId != null && __isset.userId) {
          field.Name = "userId";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(UserId);
          oprot.WriteFieldEnd();
        }
        if (Nickname != null && __isset.nickname) {
          field.Name = "nickname";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Nickname);
          oprot.WriteFieldEnd();
        }
        if (Portrait != null && __isset.portrait) {
          field.Name = "portrait";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Portrait);
          oprot.WriteFieldEnd();
        }
        if (__isset.gender) {
          field.Name = "gender";
          field.Type = TType.I32;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Gender);
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
      StringBuilder __sb = new StringBuilder("UserInfo_Public(");
      bool __first = true;
      if (UserId != null && __isset.userId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UserId: ");
        __sb.Append(UserId);
      }
      if (Nickname != null && __isset.nickname) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Nickname: ");
        __sb.Append(Nickname);
      }
      if (Portrait != null && __isset.portrait) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Portrait: ");
        __sb.Append(Portrait);
      }
      if (__isset.gender) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Gender: ");
        __sb.Append(Gender);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
