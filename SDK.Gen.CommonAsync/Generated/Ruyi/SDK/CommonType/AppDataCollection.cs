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
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;


namespace Ruyi.SDK.CommonType
{

  public partial class AppDataCollection : TBase
  {
    private string _category;
    private List<AppDataRecord> _records;

    /// <summary>
    /// The category of the records
    /// </summary>
    public string Category
    {
      get
      {
        return _category;
      }
      set
      {
        __isset.category = true;
        this._category = value;
      }
    }

    /// <summary>
    /// The records of the collection. See AppDataRecord
    /// </summary>
    public List<AppDataRecord> Records
    {
      get
      {
        return _records;
      }
      set
      {
        __isset.records = true;
        this._records = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool category;
      public bool records;
    }

    public AppDataCollection()
    {
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Category = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  Records = new List<AppDataRecord>();
                  TList _list33 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i34 = 0; _i34 < _list33.Count; ++_i34)
                  {
                    AppDataRecord _elem35;
                    _elem35 = new AppDataRecord();
                    await _elem35.ReadAsync(iprot, cancellationToken);
                    Records.Add(_elem35);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("AppDataCollection");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Category != null && __isset.category)
        {
          field.Name = "category";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Category, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Records != null && __isset.records)
        {
          field.Name = "records";
          field.Type = TType.List;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Records.Count), cancellationToken);
            foreach (AppDataRecord _iter36 in Records)
            {
              await _iter36.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder("AppDataCollection(");
      bool __first = true;
      if (Category != null && __isset.category)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Category: ");
        sb.Append(Category);
      }
      if (Records != null && __isset.records)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Records: ");
        sb.Append(Records);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
