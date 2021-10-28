using HarmonyLib;
using UnityEngine.SceneManagement;

namespace TooSpookyForMe
{
	[HarmonyPatch(typeof(SeasonalHats), "Start")]
	public static class SeasonalHatsPatch
	{
		static bool Prefix()
		{
			if (!TooSpookyForMe.Instance.Config.TryGetEntry<bool>("", "enable_menu", out var enable))
			{
				return false;
			}

			return SceneManager.GetActiveScene().name == "Main Menu" && enable.Value;
		}
	}
}