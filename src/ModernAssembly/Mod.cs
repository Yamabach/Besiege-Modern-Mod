using System;
using Modding;
using UnityEngine;

namespace Modern
{
	public class Mod : ModEntryPoint
	{
        public static GameObject myMod;
        public override void OnLoad()
		{
			// Called when the mod is loaded.
			Debug.Log("Welcome to Modern Besiege");
            myMod = new GameObject("WW2 Naval Mod");
        }
	}
}