using BepInEx;
using HarmonyLib;

namespace TooSpookyForMe
{
	public enum TimeOfYear
	{
		halloween,
		christmas,
		easter,
		none
	}

	[BepInPlugin("net.distrilul.2spooky4me", "2Spooky4Me", "1.2")]
	public class TooSpookyForMe : BaseUnityPlugin
	{
		public static TooSpookyForMe Instance { get; private set; }
		
		private void Awake()
		{
			Config.Bind("", "menu_only", false, "Enable menu music and seasons greetings only.");
			Config.Bind("", "time_of_year", TimeOfYear.halloween, "Which seasonal hats to activate");

			var harmony = new Harmony("net.distrilul.2spooky4me");
			harmony.PatchAll();

			Instance = this;
		}
	}
}
