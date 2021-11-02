using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TooSpookyForMe
{
	[HarmonyPatch(typeof(SeasonalHats), "Start")]
	public static class SeasonalHatsPatch
	{
		static bool Prefix(GameObject ___halloween, GameObject ___christmas, GameObject ___easter)
		{
			TooSpookyForMe.Instance.Config.TryGetEntry<bool>("", "menu_only", out var enable);
			TooSpookyForMe.Instance.Config.TryGetEntry<TimeOfYear>("", "time_of_year", out var time);

			if (!enable.Value || SceneManager.GetActiveScene().name == "Main Menu")
			{
				___halloween.SetActive(time.Value == TimeOfYear.halloween);
				___christmas.SetActive(time.Value == TimeOfYear.christmas);
				___easter.SetActive(time.Value == TimeOfYear.easter);
			}

			return false;
		}
	}
}