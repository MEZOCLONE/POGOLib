// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/Pokemon.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data {

  /// <summary>Holder for reflection information generated from Data/Pokemon.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/Pokemon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJEYXRhL1Bva2Vtb24ucHJvdG8SD1BPR09Qcm90b3MuRGF0YSKWBQoHUG9r",
            "ZW1vbhIKCgJpZBgBIAEoBRISCgpwb2tlbW9uX2lkGAIgASgFEgoKAmNwGAMg",
            "ASgFEg8KB3N0YW1pbmEYBCABKAUSEwoLc3RhbWluYV9tYXgYBSABKAUSDgoG",
            "bW92ZV8xGAYgASgFEg4KBm1vdmVfMhgHIAEoBRIYChBkZXBsb3llZF9mb3J0",
            "X2lkGAggASgFEhIKCm93bmVyX25hbWUYCSABKAkSDgoGaXNfZWdnGAogASgF",
            "EhwKFGVnZ19rbV93YWxrZWRfdGFyZ2V0GAsgASgFEhsKE2VnZ19rbV93YWxr",
            "ZWRfc3RhcnQYDCABKAUSDgoGb3JpZ2luGA4gASgFEhAKCGhlaWdodF9tGA8g",
            "ASgCEhEKCXdlaWdodF9rZxgQIAEoAhIZChFpbmRpdmlkdWFsX2F0dGFjaxgR",
            "IAEoBRIaChJpbmRpdmlkdWFsX2RlZmVuc2UYEiABKAUSGgoSaW5kaXZpZHVh",
            "bF9zdGFtaW5hGBMgASgFEhUKDWNwX211bHRpcGxpZXIYFCABKAUSEAoIcG9r",
            "ZWJhbGwYFSABKAUSGAoQY2FwdHVyZWRfY2VsbF9pZBgWIAEoBBIYChBiYXR0",
            "bGVzX2F0dGFja2VkGBcgASgFEhgKEGJhdHRsZXNfZGVmZW5kZWQYGCABKAUS",
            "GAoQZWdnX2luY3ViYXRvcl9pZBgZIAEoBRIYChBjcmVhdGlvbl90aW1lX21z",
            "GBogASgEEhQKDG51bV91cGdyYWRlcxgbIAEoBRIgChhhZGRpdGlvbmFsX2Nw",
            "X211bHRpcGxpZXIYHCABKAUSEAoIZmF2b3JpdGUYHSABKAUSEAoIbmlja25h",
            "bWUYHiABKAkSEQoJZnJvbV9mb3J0GB8gASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Pokemon), global::POGOProtos.Data.Pokemon.Parser, new[]{ "Id", "PokemonId", "Cp", "Stamina", "StaminaMax", "Move1", "Move2", "DeployedFortId", "OwnerName", "IsEgg", "EggKmWalkedTarget", "EggKmWalkedStart", "Origin", "HeightM", "WeightKg", "IndividualAttack", "IndividualDefense", "IndividualStamina", "CpMultiplier", "Pokeball", "CapturedCellId", "BattlesAttacked", "BattlesDefended", "EggIncubatorId", "CreationTimeMs", "NumUpgrades", "AdditionalCpMultiplier", "Favorite", "Nickname", "FromFort" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Pokemon : pb::IMessage<Pokemon> {
    private static readonly pb::MessageParser<Pokemon> _parser = new pb::MessageParser<Pokemon>(() => new Pokemon());
    public static pb::MessageParser<Pokemon> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.PokemonReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Pokemon() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Pokemon(Pokemon other) : this() {
      id_ = other.id_;
      pokemonId_ = other.pokemonId_;
      cp_ = other.cp_;
      stamina_ = other.stamina_;
      staminaMax_ = other.staminaMax_;
      move1_ = other.move1_;
      move2_ = other.move2_;
      deployedFortId_ = other.deployedFortId_;
      ownerName_ = other.ownerName_;
      isEgg_ = other.isEgg_;
      eggKmWalkedTarget_ = other.eggKmWalkedTarget_;
      eggKmWalkedStart_ = other.eggKmWalkedStart_;
      origin_ = other.origin_;
      heightM_ = other.heightM_;
      weightKg_ = other.weightKg_;
      individualAttack_ = other.individualAttack_;
      individualDefense_ = other.individualDefense_;
      individualStamina_ = other.individualStamina_;
      cpMultiplier_ = other.cpMultiplier_;
      pokeball_ = other.pokeball_;
      capturedCellId_ = other.capturedCellId_;
      battlesAttacked_ = other.battlesAttacked_;
      battlesDefended_ = other.battlesDefended_;
      eggIncubatorId_ = other.eggIncubatorId_;
      creationTimeMs_ = other.creationTimeMs_;
      numUpgrades_ = other.numUpgrades_;
      additionalCpMultiplier_ = other.additionalCpMultiplier_;
      favorite_ = other.favorite_;
      nickname_ = other.nickname_;
      fromFort_ = other.fromFort_;
    }

    public Pokemon Clone() {
      return new Pokemon(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private int pokemonId_;
    public int PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "cp" field.</summary>
    public const int CpFieldNumber = 3;
    private int cp_;
    public int Cp {
      get { return cp_; }
      set {
        cp_ = value;
      }
    }

    /// <summary>Field number for the "stamina" field.</summary>
    public const int StaminaFieldNumber = 4;
    private int stamina_;
    public int Stamina {
      get { return stamina_; }
      set {
        stamina_ = value;
      }
    }

    /// <summary>Field number for the "stamina_max" field.</summary>
    public const int StaminaMaxFieldNumber = 5;
    private int staminaMax_;
    public int StaminaMax {
      get { return staminaMax_; }
      set {
        staminaMax_ = value;
      }
    }

    /// <summary>Field number for the "move_1" field.</summary>
    public const int Move1FieldNumber = 6;
    private int move1_;
    public int Move1 {
      get { return move1_; }
      set {
        move1_ = value;
      }
    }

    /// <summary>Field number for the "move_2" field.</summary>
    public const int Move2FieldNumber = 7;
    private int move2_;
    public int Move2 {
      get { return move2_; }
      set {
        move2_ = value;
      }
    }

    /// <summary>Field number for the "deployed_fort_id" field.</summary>
    public const int DeployedFortIdFieldNumber = 8;
    private int deployedFortId_;
    public int DeployedFortId {
      get { return deployedFortId_; }
      set {
        deployedFortId_ = value;
      }
    }

    /// <summary>Field number for the "owner_name" field.</summary>
    public const int OwnerNameFieldNumber = 9;
    private string ownerName_ = "";
    public string OwnerName {
      get { return ownerName_; }
      set {
        ownerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_egg" field.</summary>
    public const int IsEggFieldNumber = 10;
    private int isEgg_;
    public int IsEgg {
      get { return isEgg_; }
      set {
        isEgg_ = value;
      }
    }

    /// <summary>Field number for the "egg_km_walked_target" field.</summary>
    public const int EggKmWalkedTargetFieldNumber = 11;
    private int eggKmWalkedTarget_;
    public int EggKmWalkedTarget {
      get { return eggKmWalkedTarget_; }
      set {
        eggKmWalkedTarget_ = value;
      }
    }

    /// <summary>Field number for the "egg_km_walked_start" field.</summary>
    public const int EggKmWalkedStartFieldNumber = 12;
    private int eggKmWalkedStart_;
    public int EggKmWalkedStart {
      get { return eggKmWalkedStart_; }
      set {
        eggKmWalkedStart_ = value;
      }
    }

    /// <summary>Field number for the "origin" field.</summary>
    public const int OriginFieldNumber = 14;
    private int origin_;
    public int Origin {
      get { return origin_; }
      set {
        origin_ = value;
      }
    }

    /// <summary>Field number for the "height_m" field.</summary>
    public const int HeightMFieldNumber = 15;
    private float heightM_;
    public float HeightM {
      get { return heightM_; }
      set {
        heightM_ = value;
      }
    }

    /// <summary>Field number for the "weight_kg" field.</summary>
    public const int WeightKgFieldNumber = 16;
    private float weightKg_;
    public float WeightKg {
      get { return weightKg_; }
      set {
        weightKg_ = value;
      }
    }

    /// <summary>Field number for the "individual_attack" field.</summary>
    public const int IndividualAttackFieldNumber = 17;
    private int individualAttack_;
    public int IndividualAttack {
      get { return individualAttack_; }
      set {
        individualAttack_ = value;
      }
    }

    /// <summary>Field number for the "individual_defense" field.</summary>
    public const int IndividualDefenseFieldNumber = 18;
    private int individualDefense_;
    public int IndividualDefense {
      get { return individualDefense_; }
      set {
        individualDefense_ = value;
      }
    }

    /// <summary>Field number for the "individual_stamina" field.</summary>
    public const int IndividualStaminaFieldNumber = 19;
    private int individualStamina_;
    public int IndividualStamina {
      get { return individualStamina_; }
      set {
        individualStamina_ = value;
      }
    }

    /// <summary>Field number for the "cp_multiplier" field.</summary>
    public const int CpMultiplierFieldNumber = 20;
    private int cpMultiplier_;
    public int CpMultiplier {
      get { return cpMultiplier_; }
      set {
        cpMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "pokeball" field.</summary>
    public const int PokeballFieldNumber = 21;
    private int pokeball_;
    public int Pokeball {
      get { return pokeball_; }
      set {
        pokeball_ = value;
      }
    }

    /// <summary>Field number for the "captured_cell_id" field.</summary>
    public const int CapturedCellIdFieldNumber = 22;
    private ulong capturedCellId_;
    public ulong CapturedCellId {
      get { return capturedCellId_; }
      set {
        capturedCellId_ = value;
      }
    }

    /// <summary>Field number for the "battles_attacked" field.</summary>
    public const int BattlesAttackedFieldNumber = 23;
    private int battlesAttacked_;
    public int BattlesAttacked {
      get { return battlesAttacked_; }
      set {
        battlesAttacked_ = value;
      }
    }

    /// <summary>Field number for the "battles_defended" field.</summary>
    public const int BattlesDefendedFieldNumber = 24;
    private int battlesDefended_;
    public int BattlesDefended {
      get { return battlesDefended_; }
      set {
        battlesDefended_ = value;
      }
    }

    /// <summary>Field number for the "egg_incubator_id" field.</summary>
    public const int EggIncubatorIdFieldNumber = 25;
    private int eggIncubatorId_;
    public int EggIncubatorId {
      get { return eggIncubatorId_; }
      set {
        eggIncubatorId_ = value;
      }
    }

    /// <summary>Field number for the "creation_time_ms" field.</summary>
    public const int CreationTimeMsFieldNumber = 26;
    private ulong creationTimeMs_;
    public ulong CreationTimeMs {
      get { return creationTimeMs_; }
      set {
        creationTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "num_upgrades" field.</summary>
    public const int NumUpgradesFieldNumber = 27;
    private int numUpgrades_;
    public int NumUpgrades {
      get { return numUpgrades_; }
      set {
        numUpgrades_ = value;
      }
    }

    /// <summary>Field number for the "additional_cp_multiplier" field.</summary>
    public const int AdditionalCpMultiplierFieldNumber = 28;
    private int additionalCpMultiplier_;
    public int AdditionalCpMultiplier {
      get { return additionalCpMultiplier_; }
      set {
        additionalCpMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "favorite" field.</summary>
    public const int FavoriteFieldNumber = 29;
    private int favorite_;
    public int Favorite {
      get { return favorite_; }
      set {
        favorite_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 30;
    private string nickname_ = "";
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "from_fort" field.</summary>
    public const int FromFortFieldNumber = 31;
    private int fromFort_;
    public int FromFort {
      get { return fromFort_; }
      set {
        fromFort_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Pokemon);
    }

    public bool Equals(Pokemon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (PokemonId != other.PokemonId) return false;
      if (Cp != other.Cp) return false;
      if (Stamina != other.Stamina) return false;
      if (StaminaMax != other.StaminaMax) return false;
      if (Move1 != other.Move1) return false;
      if (Move2 != other.Move2) return false;
      if (DeployedFortId != other.DeployedFortId) return false;
      if (OwnerName != other.OwnerName) return false;
      if (IsEgg != other.IsEgg) return false;
      if (EggKmWalkedTarget != other.EggKmWalkedTarget) return false;
      if (EggKmWalkedStart != other.EggKmWalkedStart) return false;
      if (Origin != other.Origin) return false;
      if (HeightM != other.HeightM) return false;
      if (WeightKg != other.WeightKg) return false;
      if (IndividualAttack != other.IndividualAttack) return false;
      if (IndividualDefense != other.IndividualDefense) return false;
      if (IndividualStamina != other.IndividualStamina) return false;
      if (CpMultiplier != other.CpMultiplier) return false;
      if (Pokeball != other.Pokeball) return false;
      if (CapturedCellId != other.CapturedCellId) return false;
      if (BattlesAttacked != other.BattlesAttacked) return false;
      if (BattlesDefended != other.BattlesDefended) return false;
      if (EggIncubatorId != other.EggIncubatorId) return false;
      if (CreationTimeMs != other.CreationTimeMs) return false;
      if (NumUpgrades != other.NumUpgrades) return false;
      if (AdditionalCpMultiplier != other.AdditionalCpMultiplier) return false;
      if (Favorite != other.Favorite) return false;
      if (Nickname != other.Nickname) return false;
      if (FromFort != other.FromFort) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      if (Cp != 0) hash ^= Cp.GetHashCode();
      if (Stamina != 0) hash ^= Stamina.GetHashCode();
      if (StaminaMax != 0) hash ^= StaminaMax.GetHashCode();
      if (Move1 != 0) hash ^= Move1.GetHashCode();
      if (Move2 != 0) hash ^= Move2.GetHashCode();
      if (DeployedFortId != 0) hash ^= DeployedFortId.GetHashCode();
      if (OwnerName.Length != 0) hash ^= OwnerName.GetHashCode();
      if (IsEgg != 0) hash ^= IsEgg.GetHashCode();
      if (EggKmWalkedTarget != 0) hash ^= EggKmWalkedTarget.GetHashCode();
      if (EggKmWalkedStart != 0) hash ^= EggKmWalkedStart.GetHashCode();
      if (Origin != 0) hash ^= Origin.GetHashCode();
      if (HeightM != 0F) hash ^= HeightM.GetHashCode();
      if (WeightKg != 0F) hash ^= WeightKg.GetHashCode();
      if (IndividualAttack != 0) hash ^= IndividualAttack.GetHashCode();
      if (IndividualDefense != 0) hash ^= IndividualDefense.GetHashCode();
      if (IndividualStamina != 0) hash ^= IndividualStamina.GetHashCode();
      if (CpMultiplier != 0) hash ^= CpMultiplier.GetHashCode();
      if (Pokeball != 0) hash ^= Pokeball.GetHashCode();
      if (CapturedCellId != 0UL) hash ^= CapturedCellId.GetHashCode();
      if (BattlesAttacked != 0) hash ^= BattlesAttacked.GetHashCode();
      if (BattlesDefended != 0) hash ^= BattlesDefended.GetHashCode();
      if (EggIncubatorId != 0) hash ^= EggIncubatorId.GetHashCode();
      if (CreationTimeMs != 0UL) hash ^= CreationTimeMs.GetHashCode();
      if (NumUpgrades != 0) hash ^= NumUpgrades.GetHashCode();
      if (AdditionalCpMultiplier != 0) hash ^= AdditionalCpMultiplier.GetHashCode();
      if (Favorite != 0) hash ^= Favorite.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (FromFort != 0) hash ^= FromFort.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (PokemonId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PokemonId);
      }
      if (Cp != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Cp);
      }
      if (Stamina != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Stamina);
      }
      if (StaminaMax != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(StaminaMax);
      }
      if (Move1 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Move1);
      }
      if (Move2 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Move2);
      }
      if (DeployedFortId != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(DeployedFortId);
      }
      if (OwnerName.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(OwnerName);
      }
      if (IsEgg != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(IsEgg);
      }
      if (EggKmWalkedTarget != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(EggKmWalkedTarget);
      }
      if (EggKmWalkedStart != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(EggKmWalkedStart);
      }
      if (Origin != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Origin);
      }
      if (HeightM != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(HeightM);
      }
      if (WeightKg != 0F) {
        output.WriteRawTag(133, 1);
        output.WriteFloat(WeightKg);
      }
      if (IndividualAttack != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(IndividualAttack);
      }
      if (IndividualDefense != 0) {
        output.WriteRawTag(144, 1);
        output.WriteInt32(IndividualDefense);
      }
      if (IndividualStamina != 0) {
        output.WriteRawTag(152, 1);
        output.WriteInt32(IndividualStamina);
      }
      if (CpMultiplier != 0) {
        output.WriteRawTag(160, 1);
        output.WriteInt32(CpMultiplier);
      }
      if (Pokeball != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(Pokeball);
      }
      if (CapturedCellId != 0UL) {
        output.WriteRawTag(176, 1);
        output.WriteUInt64(CapturedCellId);
      }
      if (BattlesAttacked != 0) {
        output.WriteRawTag(184, 1);
        output.WriteInt32(BattlesAttacked);
      }
      if (BattlesDefended != 0) {
        output.WriteRawTag(192, 1);
        output.WriteInt32(BattlesDefended);
      }
      if (EggIncubatorId != 0) {
        output.WriteRawTag(200, 1);
        output.WriteInt32(EggIncubatorId);
      }
      if (CreationTimeMs != 0UL) {
        output.WriteRawTag(208, 1);
        output.WriteUInt64(CreationTimeMs);
      }
      if (NumUpgrades != 0) {
        output.WriteRawTag(216, 1);
        output.WriteInt32(NumUpgrades);
      }
      if (AdditionalCpMultiplier != 0) {
        output.WriteRawTag(224, 1);
        output.WriteInt32(AdditionalCpMultiplier);
      }
      if (Favorite != 0) {
        output.WriteRawTag(232, 1);
        output.WriteInt32(Favorite);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(242, 1);
        output.WriteString(Nickname);
      }
      if (FromFort != 0) {
        output.WriteRawTag(248, 1);
        output.WriteInt32(FromFort);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonId);
      }
      if (Cp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Cp);
      }
      if (Stamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stamina);
      }
      if (StaminaMax != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StaminaMax);
      }
      if (Move1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Move1);
      }
      if (Move2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Move2);
      }
      if (DeployedFortId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DeployedFortId);
      }
      if (OwnerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerName);
      }
      if (IsEgg != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IsEgg);
      }
      if (EggKmWalkedTarget != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggKmWalkedTarget);
      }
      if (EggKmWalkedStart != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggKmWalkedStart);
      }
      if (Origin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Origin);
      }
      if (HeightM != 0F) {
        size += 1 + 4;
      }
      if (WeightKg != 0F) {
        size += 2 + 4;
      }
      if (IndividualAttack != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualAttack);
      }
      if (IndividualDefense != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualDefense);
      }
      if (IndividualStamina != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(IndividualStamina);
      }
      if (CpMultiplier != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(CpMultiplier);
      }
      if (Pokeball != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Pokeball);
      }
      if (CapturedCellId != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(CapturedCellId);
      }
      if (BattlesAttacked != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattlesAttacked);
      }
      if (BattlesDefended != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattlesDefended);
      }
      if (EggIncubatorId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(EggIncubatorId);
      }
      if (CreationTimeMs != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(CreationTimeMs);
      }
      if (NumUpgrades != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(NumUpgrades);
      }
      if (AdditionalCpMultiplier != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(AdditionalCpMultiplier);
      }
      if (Favorite != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Favorite);
      }
      if (Nickname.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (FromFort != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(FromFort);
      }
      return size;
    }

    public void MergeFrom(Pokemon other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
      if (other.Cp != 0) {
        Cp = other.Cp;
      }
      if (other.Stamina != 0) {
        Stamina = other.Stamina;
      }
      if (other.StaminaMax != 0) {
        StaminaMax = other.StaminaMax;
      }
      if (other.Move1 != 0) {
        Move1 = other.Move1;
      }
      if (other.Move2 != 0) {
        Move2 = other.Move2;
      }
      if (other.DeployedFortId != 0) {
        DeployedFortId = other.DeployedFortId;
      }
      if (other.OwnerName.Length != 0) {
        OwnerName = other.OwnerName;
      }
      if (other.IsEgg != 0) {
        IsEgg = other.IsEgg;
      }
      if (other.EggKmWalkedTarget != 0) {
        EggKmWalkedTarget = other.EggKmWalkedTarget;
      }
      if (other.EggKmWalkedStart != 0) {
        EggKmWalkedStart = other.EggKmWalkedStart;
      }
      if (other.Origin != 0) {
        Origin = other.Origin;
      }
      if (other.HeightM != 0F) {
        HeightM = other.HeightM;
      }
      if (other.WeightKg != 0F) {
        WeightKg = other.WeightKg;
      }
      if (other.IndividualAttack != 0) {
        IndividualAttack = other.IndividualAttack;
      }
      if (other.IndividualDefense != 0) {
        IndividualDefense = other.IndividualDefense;
      }
      if (other.IndividualStamina != 0) {
        IndividualStamina = other.IndividualStamina;
      }
      if (other.CpMultiplier != 0) {
        CpMultiplier = other.CpMultiplier;
      }
      if (other.Pokeball != 0) {
        Pokeball = other.Pokeball;
      }
      if (other.CapturedCellId != 0UL) {
        CapturedCellId = other.CapturedCellId;
      }
      if (other.BattlesAttacked != 0) {
        BattlesAttacked = other.BattlesAttacked;
      }
      if (other.BattlesDefended != 0) {
        BattlesDefended = other.BattlesDefended;
      }
      if (other.EggIncubatorId != 0) {
        EggIncubatorId = other.EggIncubatorId;
      }
      if (other.CreationTimeMs != 0UL) {
        CreationTimeMs = other.CreationTimeMs;
      }
      if (other.NumUpgrades != 0) {
        NumUpgrades = other.NumUpgrades;
      }
      if (other.AdditionalCpMultiplier != 0) {
        AdditionalCpMultiplier = other.AdditionalCpMultiplier;
      }
      if (other.Favorite != 0) {
        Favorite = other.Favorite;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.FromFort != 0) {
        FromFort = other.FromFort;
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
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            PokemonId = input.ReadInt32();
            break;
          }
          case 24: {
            Cp = input.ReadInt32();
            break;
          }
          case 32: {
            Stamina = input.ReadInt32();
            break;
          }
          case 40: {
            StaminaMax = input.ReadInt32();
            break;
          }
          case 48: {
            Move1 = input.ReadInt32();
            break;
          }
          case 56: {
            Move2 = input.ReadInt32();
            break;
          }
          case 64: {
            DeployedFortId = input.ReadInt32();
            break;
          }
          case 74: {
            OwnerName = input.ReadString();
            break;
          }
          case 80: {
            IsEgg = input.ReadInt32();
            break;
          }
          case 88: {
            EggKmWalkedTarget = input.ReadInt32();
            break;
          }
          case 96: {
            EggKmWalkedStart = input.ReadInt32();
            break;
          }
          case 112: {
            Origin = input.ReadInt32();
            break;
          }
          case 125: {
            HeightM = input.ReadFloat();
            break;
          }
          case 133: {
            WeightKg = input.ReadFloat();
            break;
          }
          case 136: {
            IndividualAttack = input.ReadInt32();
            break;
          }
          case 144: {
            IndividualDefense = input.ReadInt32();
            break;
          }
          case 152: {
            IndividualStamina = input.ReadInt32();
            break;
          }
          case 160: {
            CpMultiplier = input.ReadInt32();
            break;
          }
          case 168: {
            Pokeball = input.ReadInt32();
            break;
          }
          case 176: {
            CapturedCellId = input.ReadUInt64();
            break;
          }
          case 184: {
            BattlesAttacked = input.ReadInt32();
            break;
          }
          case 192: {
            BattlesDefended = input.ReadInt32();
            break;
          }
          case 200: {
            EggIncubatorId = input.ReadInt32();
            break;
          }
          case 208: {
            CreationTimeMs = input.ReadUInt64();
            break;
          }
          case 216: {
            NumUpgrades = input.ReadInt32();
            break;
          }
          case 224: {
            AdditionalCpMultiplier = input.ReadInt32();
            break;
          }
          case 232: {
            Favorite = input.ReadInt32();
            break;
          }
          case 242: {
            Nickname = input.ReadString();
            break;
          }
          case 248: {
            FromFort = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code