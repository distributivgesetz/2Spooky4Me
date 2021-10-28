using BepInEx;
using HarmonyLib;

namespace TooSpookyForMe
{
	[BepInPlugin("net.distrilul.2spooky4me", "2Spooky4Me", "1.0")]
	public class TooSpookyForMe : BaseUnityPlugin
	{
		private void Awake()
		{
			var harmony = new Harmony("net.distrilul.2spooky4me");
			harmony.PatchAll();
		}
	}
}