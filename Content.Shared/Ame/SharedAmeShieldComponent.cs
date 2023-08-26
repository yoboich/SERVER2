﻿using Robust.Shared.Serialization;

namespace Content.Shared.Ame;

[Virtual]
public partial class SharedAmeShieldComponent : Component
{
}

[Serializable, NetSerializable]
public enum AmeShieldVisuals
{
    Core,
    CoreState
}

[Serializable, NetSerializable]
public enum AmeCoreState
{
    Off,
    Weak,
    Strong
}
