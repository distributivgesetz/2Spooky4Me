using BepInEx;
using HarmonyLib;

namespace TooSpookyForMe
{
	[BepInPlugin("net.distrilul.2spooky4me", "2Spooky4Me", "1.1")]
	public class TooSpookyForMe : BaseUnityPlugin
	{
		public static TooSpookyForMe Instance { get; private set; }
		
		private void Awake()
		{
			Config.Bind("", "enable_menu", false, "Leave menu music and seasons greetings enabled.");

			var harmony = new Harmony("net.distrilul.2spooky4me");
			harmony.PatchAll();

			Instance = this;
		}
	}
}