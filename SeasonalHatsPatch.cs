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
			TooSpookyForMe.Instance.Config.TryGetEntry<bool>("", "enable_menu", out var enable);
			TooSpookyForMe.Instance.Config.TryGetEntry<TimeOfYear>("", "time_of_year", out var time);
			if (SceneManager.GetActiveScene().name == "Main Menu")
			{
				___halloween.SetActive(time.Value == TimeOfYear.Halloween && enable.Value);
				___christmas.SetActive(time.Value == TimeOfYear.Christmas && enable.Value);
				___easter.SetActive(time.Value == TimeOfYear.Easter && enable.Value);
			}
			else
			{
				___halloween.SetActive(time.Value == TimeOfYear.Halloween);
				___christmas.SetActive(time.Value == TimeOfYear.Christmas);
				___easter.SetActive(time.Value == TimeOfYear.Easter);
			}

			return false;
		}
	}
}