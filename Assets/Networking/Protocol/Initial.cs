// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Initial.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Org.Dragonet.Cloudland.Net.Protocol {

  /// <summary>Holder for reflection information generated from Initial.proto</summary>
  public static partial class InitialReflection {

    #region Descriptor
    /// <summary>File descriptor for Initial.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InitialReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1Jbml0aWFsLnByb3RvEiNvcmcuZHJhZ29uZXQuY2xvdWRsYW5kLm5ldC5w",
            "cm90b2NvbCJ7ChVTZXJ2ZXJKb2luR2FtZU1lc3NhZ2USDAoEdXVpZBgBIAEo",
            "CRIQCgh1c2VybmFtZRgCIAEoCRIJCgF4GAMgASgCEgkKAXkYBCABKAISCQoB",
            "ehgFIAEoAhIQCghnYW1lTW9kZRgGIAEoDRIPCgd3b3JsZElkGAcgASgNIq0B",
            "Ch5TZXJ2ZXJVcGRhdGVFbnZpcm9ubWVudE1lc3NhZ2USYAoEdHlwZRgBIAEo",
            "DjJSLm9yZy5kcmFnb25ldC5jbG91ZGxhbmQubmV0LnByb3RvY29sLlNlcnZl",
            "clVwZGF0ZUVudmlyb25tZW50TWVzc2FnZS5FbnZpcm9tZW50VHlwZRINCgV2",
            "YWx1ZRgCIAEoBSIaCg5FbnZpcm9tZW50VHlwZRIICgRUSU1FEAAiKQoXU2Vy",
            "dmVyRGlzY29ubmVjdE1lc3NhZ2USDgoGcmVhc29uGAEgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerJoinGameMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerJoinGameMessage.Parser, new[]{ "Uuid", "Username", "X", "Y", "Z", "GameMode", "WorldId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateEnvironmentMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateEnvironmentMessage.Parser, new[]{ "Type", "Value" }, null, new[]{ typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateEnvironmentMessage.Types.EnviromentType) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Org.Dragonet.Cloudland.Net.Protocol.ServerDisconnectMessage), global::Org.Dragonet.Cloudland.Net.Protocol.ServerDisconnectMessage.Parser, new[]{ "Reason" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ServerJoinGameMessage : pb::IMessage<ServerJoinGameMessage> {
    private static readonly pb::MessageParser<ServerJoinGameMessage> _parser = new pb::MessageParser<ServerJoinGameMessage>(() => new ServerJoinGameMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerJoinGameMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.InitialReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerJoinGameMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerJoinGameMessage(ServerJoinGameMessage other) : this() {
      uuid_ = other.uuid_;
      username_ = other.username_;
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      gameMode_ = other.gameMode_;
      worldId_ = other.worldId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerJoinGameMessage Clone() {
      return new ServerJoinGameMessage(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private string uuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uuid {
      get { return uuid_; }
      set {
        uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 2;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 3;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 4;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 5;
    private float z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    /// <summary>Field number for the "gameMode" field.</summary>
    public const int GameModeFieldNumber = 6;
    private uint gameMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint GameMode {
      get { return gameMode_; }
      set {
        gameMode_ = value;
      }
    }

    /// <summary>Field number for the "worldId" field.</summary>
    public const int WorldIdFieldNumber = 7;
    private uint worldId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint WorldId {
      get { return worldId_; }
      set {
        worldId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerJoinGameMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerJoinGameMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uuid != other.Uuid) return false;
      if (Username != other.Username) return false;
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (Z != other.Z) return false;
      if (GameMode != other.GameMode) return false;
      if (WorldId != other.WorldId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (X != 0F) hash ^= X.GetHashCode();
      if (Y != 0F) hash ^= Y.GetHashCode();
      if (Z != 0F) hash ^= Z.GetHashCode();
      if (GameMode != 0) hash ^= GameMode.GetHashCode();
      if (WorldId != 0) hash ^= WorldId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (Username.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Username);
      }
      if (X != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Z);
      }
      if (GameMode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GameMode);
      }
      if (WorldId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(WorldId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
      }
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (Z != 0F) {
        size += 1 + 4;
      }
      if (GameMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameMode);
      }
      if (WorldId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerJoinGameMessage other) {
      if (other == null) {
        return;
      }
      if (other.Uuid.Length != 0) {
        Uuid = other.Uuid;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Z != 0F) {
        Z = other.Z;
      }
      if (other.GameMode != 0) {
        GameMode = other.GameMode;
      }
      if (other.WorldId != 0) {
        WorldId = other.WorldId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Uuid = input.ReadString();
            break;
          }
          case 18: {
            Username = input.ReadString();
            break;
          }
          case 29: {
            X = input.ReadFloat();
            break;
          }
          case 37: {
            Y = input.ReadFloat();
            break;
          }
          case 45: {
            Z = input.ReadFloat();
            break;
          }
          case 48: {
            GameMode = input.ReadUInt32();
            break;
          }
          case 56: {
            WorldId = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServerUpdateEnvironmentMessage : pb::IMessage<ServerUpdateEnvironmentMessage> {
    private static readonly pb::MessageParser<ServerUpdateEnvironmentMessage> _parser = new pb::MessageParser<ServerUpdateEnvironmentMessage>(() => new ServerUpdateEnvironmentMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerUpdateEnvironmentMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.InitialReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateEnvironmentMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateEnvironmentMessage(ServerUpdateEnvironmentMessage other) : this() {
      type_ = other.type_;
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerUpdateEnvironmentMessage Clone() {
      return new ServerUpdateEnvironmentMessage(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateEnvironmentMessage.Types.EnviromentType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateEnvironmentMessage.Types.EnviromentType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private int value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerUpdateEnvironmentMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerUpdateEnvironmentMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Value != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Value != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerUpdateEnvironmentMessage other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Value != 0) {
        Value = other.Value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            type_ = (global::Org.Dragonet.Cloudland.Net.Protocol.ServerUpdateEnvironmentMessage.Types.EnviromentType) input.ReadEnum();
            break;
          }
          case 16: {
            Value = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ServerUpdateEnvironmentMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum EnviromentType {
        [pbr::OriginalName("TIME")] Time = 0,
      }

    }
    #endregion

  }

  public sealed partial class ServerDisconnectMessage : pb::IMessage<ServerDisconnectMessage> {
    private static readonly pb::MessageParser<ServerDisconnectMessage> _parser = new pb::MessageParser<ServerDisconnectMessage>(() => new ServerDisconnectMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerDisconnectMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Org.Dragonet.Cloudland.Net.Protocol.InitialReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerDisconnectMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerDisconnectMessage(ServerDisconnectMessage other) : this() {
      reason_ = other.reason_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerDisconnectMessage Clone() {
      return new ServerDisconnectMessage(this);
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 1;
    private string reason_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reason {
      get { return reason_; }
      set {
        reason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerDisconnectMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerDisconnectMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reason != other.Reason) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Reason.Length != 0) hash ^= Reason.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Reason.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Reason);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Reason.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reason);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerDisconnectMessage other) {
      if (other == null) {
        return;
      }
      if (other.Reason.Length != 0) {
        Reason = other.Reason;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Reason = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
