using BepInEx;
using HarmonyLib;

namespace TooSpookyForMe
{
	public enum TimeOfYear
    {
		Halloween,
		Christmas,
		Easter
    }

	[BepInPlugin("net.distrilul.2spooky4me", "2Spooky4Me", "1.1")]
	public class TooSpookyForMe : BaseUnityPlugin
	{
		public static TooSpookyForMe Instance { get; private set; }
		
		private void Awake()
		{
			Config.Bind("", "enable_menu", false, "Leave menu music and seasons greetings enabled.");
			Config.Bind("", "time_of_year", TimeOfYear.Halloween, "Which seasonal hats to activate");

			var harmony = new Harmony("net.distrilul.2spooky4me");
			harmony.PatchAll();

			Instance = this;
		}
	}
}