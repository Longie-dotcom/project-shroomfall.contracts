#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.NotificationDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/notification-domain")]
#endif
    public enum NotificationType
    {
        // --- Service / ops ---
        ContentUpdation,        // new content, patch notes (existing, keep at 0)
        Maintenance,            // scheduled downtime
        Fix,                    // small urgent fix

        // --- General messaging ---
        Announcement,           // generic news, the safe default
        Information,            // neutral tip or FYI
        Warning,                // something players should act on
        Policy,                 // rules, terms, fair-play reminder

        // --- Events ---
        EventStart,             // limited-time event begins
        EventEnd,               // event ending or ended
        Seasonal,               // holiday or season themed
        Community,              // contests, community highlights

        // --- Social / security ---
        Security,               // account safety, phishing warnings
        Celebration,            // anniversary, thank-you messages
    }
}