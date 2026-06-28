using System.ComponentModel;

namespace Blish_HUD.Graphics {
    public enum DpiMethod : int {
        [LocalizedDescription("Setting_DPIScaling_SyncWithGame")]
        SyncWithGame = 0,

        [LocalizedDescription("Setting_DPIScaling_UseGameDpi")]
        UseGameDpi = 1,

        [LocalizedDescription("Setting_DPIScaling_NoScaling")]
        NoScaling = 2
    }
}
