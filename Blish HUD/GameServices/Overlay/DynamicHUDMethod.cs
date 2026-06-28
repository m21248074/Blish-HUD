using System.ComponentModel;

namespace Blish_HUD.Graphics {
    public enum DynamicHUDMethod : int {
        [LocalizedDescription("Setting_DynamicHUD_AlwaysShow")]
        AlwaysShow = 0,

        [LocalizedDescription("Setting_DynamicHUD_ShowPeaceful")]
        ShowPeaceful = 1,

        [LocalizedDescription("Setting_DynamicHUD_ShowInCombat")]
        ShowInCombat = 2,

        [LocalizedDescription("Setting_DynamicHUD_NeverShow")]
        NeverShow = 3
    }
}
