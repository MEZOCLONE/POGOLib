// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/AppliedItem.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from Inventory/AppliedItem.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class AppliedItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/AppliedItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppliedItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtJbnZlbnRvcnkvQXBwbGllZEl0ZW0ucHJvdG8SFFBPR09Qcm90b3MuSW52",
            "ZW50b3J5GhhJbnZlbnRvcnkvSXRlbVR5cGUucHJvdG8aIEludmVudG9yeS9J",
            "dGVtVHlwZUNhdGVnb3J5LnByb3RvIqsBCgtBcHBsaWVkSXRlbRIxCglpdGVt",
            "X3R5cGUYASABKA4yHi5QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtVHlwZRJC",
            "ChJpdGVtX3R5cGVfY2F0ZWdvcnkYAiABKA4yJi5QT0dPUHJvdG9zLkludmVu",
            "dG9yeS5JdGVtVHlwZUNhdGVnb3J5EhEKCWV4cGlyZV9tcxgDIAEoAxISCgph",
            "cHBsaWVkX21zGAQgASgDUABQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.ItemTypeReflection.Descriptor, global::POGOProtos.Inventory.ItemTypeCategoryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.AppliedItem), global::POGOProtos.Inventory.AppliedItem.Parser, new[]{ "ItemType", "ItemTypeCategory", "ExpireMs", "AppliedMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AppliedItem : pb::IMessage<AppliedItem> {
    private static readonly pb::MessageParser<AppliedItem> _parser = new pb::MessageParser<AppliedItem>(() => new AppliedItem());
    public static pb::MessageParser<AppliedItem> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.AppliedItemReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public AppliedItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    public AppliedItem(AppliedItem other) : this() {
      itemType_ = other.itemType_;
      itemTypeCategory_ = other.itemTypeCategory_;
      expireMs_ = other.expireMs_;
      appliedMs_ = other.appliedMs_;
    }

    public AppliedItem Clone() {
      return new AppliedItem(this);
    }

    /// <summary>Field number for the "item_type" field.</summary>
    public const int ItemTypeFieldNumber = 1;
    private global::POGOProtos.Inventory.ItemType itemType_ = 0;
    public global::POGOProtos.Inventory.ItemType ItemType {
      get { return itemType_; }
      set {
        itemType_ = value;
      }
    }

    /// <summary>Field number for the "item_type_category" field.</summary>
    public const int ItemTypeCategoryFieldNumber = 2;
    private global::POGOProtos.Inventory.ItemTypeCategory itemTypeCategory_ = 0;
    public global::POGOProtos.Inventory.ItemTypeCategory ItemTypeCategory {
      get { return itemTypeCategory_; }
      set {
        itemTypeCategory_ = value;
      }
    }

    /// <summary>Field number for the "expire_ms" field.</summary>
    public const int ExpireMsFieldNumber = 3;
    private long expireMs_;
    public long ExpireMs {
      get { return expireMs_; }
      set {
        expireMs_ = value;
      }
    }

    /// <summary>Field number for the "applied_ms" field.</summary>
    public const int AppliedMsFieldNumber = 4;
    private long appliedMs_;
    public long AppliedMs {
      get { return appliedMs_; }
      set {
        appliedMs_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as AppliedItem);
    }

    public bool Equals(AppliedItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemType != other.ItemType) return false;
      if (ItemTypeCategory != other.ItemTypeCategory) return false;
      if (ExpireMs != other.ExpireMs) return false;
      if (AppliedMs != other.AppliedMs) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemType != 0) hash ^= ItemType.GetHashCode();
      if (ItemTypeCategory != 0) hash ^= ItemTypeCategory.GetHashCode();
      if (ExpireMs != 0L) hash ^= ExpireMs.GetHashCode();
      if (AppliedMs != 0L) hash ^= AppliedMs.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemType);
      }
      if (ItemTypeCategory != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ItemTypeCategory);
      }
      if (ExpireMs != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ExpireMs);
      }
      if (AppliedMs != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(AppliedMs);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemType);
      }
      if (ItemTypeCategory != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemTypeCategory);
      }
      if (ExpireMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpireMs);
      }
      if (AppliedMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AppliedMs);
      }
      return size;
    }

    public void MergeFrom(AppliedItem other) {
      if (other == null) {
        return;
      }
      if (other.ItemType != 0) {
        ItemType = other.ItemType;
      }
      if (other.ItemTypeCategory != 0) {
        ItemTypeCategory = other.ItemTypeCategory;
      }
      if (other.ExpireMs != 0L) {
        ExpireMs = other.ExpireMs;
      }
      if (other.AppliedMs != 0L) {
        AppliedMs = other.AppliedMs;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            itemType_ = (global::POGOProtos.Inventory.ItemType) input.ReadEnum();
            break;
          }
          case 16: {
            itemTypeCategory_ = (global::POGOProtos.Inventory.ItemTypeCategory) input.ReadEnum();
            break;
          }
          case 24: {
            ExpireMs = input.ReadInt64();
            break;
          }
          case 32: {
            AppliedMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code