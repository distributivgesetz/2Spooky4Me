using HarmonyLib;

namespace TooSpookyForMe
{
	[HarmonyPatch(typeof(SeasonalHats), "Start")]
	public static class SeasonalHatsPatch
	{
		static bool Prefix()
		{
			return false;
		}
	}
}