using System.ComponentModel;

namespace Blish_HUD.Graphics {
    public enum ManualUISize : int {
        [LocalizedDescription("Setting_UIScaling_SyncWithGame")]
        SyncWithGame = 0,

        [LocalizedDescription("Setting_UIScaling_Small")]
        Small = 1,

        [LocalizedDescription("Setting_UIScaling_Normal")]
        Normal = 2,

        [LocalizedDescription("Setting_UIScaling_Large")]
        Large = 3,

        [LocalizedDescription("Setting_UIScaling_Larger")]
        Larger = 4
    }
}
