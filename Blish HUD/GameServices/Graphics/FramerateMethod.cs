using System.ComponentModel;

namespace Blish_HUD.Graphics {

    public enum FramerateMethod : int {
        Custom        = -1,
        SyncWithGame  = 0,
        [LocalizedDescription("Setting_FramerateLimiter_LockedTo30Fps")]
        LockedTo30Fps = 1,
        [LocalizedDescription("Setting_FramerateLimiter_LockedTo60Fps")]
        LockedTo60Fps = 2,
        [LocalizedDescription("Setting_FramerateLimiter_LockedTo90Fps")]
        LockedTo90Fps = 3,
        [LocalizedDescription("Setting_FramerateLimiter_Unlimited")]
        Unlimited     = 4,
        TrueUnlimited = 5,
    }

}
