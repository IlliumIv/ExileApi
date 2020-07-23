using System;

namespace ExileCore.Shared.Enums
{
    [Flags]
    public enum ActionFlags
    {
        None = 0,
        UsingAbility = 2,

        //Actor is currently playing the "attack" animation, and therefor locked in a cooldown before any other action.
        AbilityCooldownActive = 16,

        //Actor is currently playing the "attack" animation, this is 2 + 16 when running in predictive mode
        UsingAbilityAbilityCooldown = 18,

        Dead = 64,
        Moving = 128,

        /// actor is in the washed up state and false otherwise.
        WashedUpState = 256,
        HasMines = 2048
    }
}
