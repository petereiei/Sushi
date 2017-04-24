using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;


			public static class Load  {

			    static public void LoadData()
			    {
			        string loadjson = PlayerPrefs.GetString("PlayerSaveData");
			        PlayerSaveData Loadplayer = JsonMapper.ToObject<PlayerSaveData>(loadjson);

			        PlayerStatus.Money = Loadplayer.Money;
			        PlayerStatus.SushibarSlotLV = Loadplayer.Furnitue.SushibarSlotLV;

			        PlayerStatus.Table1On = Loadplayer.Furnitue.Table1On;
			        PlayerStatus.Table2On = Loadplayer.Furnitue.Table2On;
			        PlayerStatus.Table3On = Loadplayer.Furnitue.Table3On;
			        PlayerStatus.Table4On = Loadplayer.Furnitue.Table4On;
			        PlayerStatus.Table5On = Loadplayer.Furnitue.Table5On;
			        PlayerStatus.Table6On = Loadplayer.Furnitue.Table6On;
			        PlayerStatus.Table7On = Loadplayer.Furnitue.Table7On;
			        PlayerStatus.Table8On = Loadplayer.Furnitue.Table8On;

			        PlayerStatus.Table1Buy = Loadplayer.Furnitue.Table1Buy;
			        PlayerStatus.Table2Buy = Loadplayer.Furnitue.Table2Buy;
			        PlayerStatus.Table3Buy = Loadplayer.Furnitue.Table3Buy;
			        PlayerStatus.Table4Buy = Loadplayer.Furnitue.Table4Buy;
			        PlayerStatus.Table5Buy = Loadplayer.Furnitue.Table5Buy;
			        PlayerStatus.Table6Buy = Loadplayer.Furnitue.Table6Buy;
			        PlayerStatus.Table7Buy = Loadplayer.Furnitue.Table7Buy;
			        PlayerStatus.Table8Buy = Loadplayer.Furnitue.Table8Buy;

			        PlayerStatus.CookingQualityLV = Loadplayer.CookingSkill.CookingQualityLV;
			        PlayerStatus.CookingSpeedLV = Loadplayer.CookingSkill.CookingSpeedLV;
			        PlayerStatus.MultiCookingLV = Loadplayer.CookingSkill.MultiCookingLV;

			        PlayerStatus.Sushi1Unlock = Loadplayer.RecipeUnlock.Sushi1Unlock;
			        PlayerStatus.Sushi2Unlock = Loadplayer.RecipeUnlock.Sushi2Unlock;
			        PlayerStatus.Sushi3Unlock = Loadplayer.RecipeUnlock.Sushi3Unlock;
			        PlayerStatus.Sushi4Unlock = Loadplayer.RecipeUnlock.Sushi4Unlock;
			        PlayerStatus.Sushi5Unlock = Loadplayer.RecipeUnlock.Sushi5Unlock;
			        PlayerStatus.SushiSet1Unlock = Loadplayer.RecipeUnlock.SushiSet1Unlock;

			        PlayerStatus.Sushi6Unlock = Loadplayer.RecipeUnlock.Sushi6Unlock;
			        PlayerStatus.Sushi7Unlock = Loadplayer.RecipeUnlock.Sushi7Unlock;
			        PlayerStatus.Sushi8Unlock = Loadplayer.RecipeUnlock.Sushi8Unlock;
			        PlayerStatus.Sushi9Unlock = Loadplayer.RecipeUnlock.Sushi9Unlock;
			        PlayerStatus.Sushi10Unlock = Loadplayer.RecipeUnlock.Sushi10Unlock;
			        PlayerStatus.SushiSet2Unlock = Loadplayer.RecipeUnlock.SushiSet2Unlock;
			        
			        Debug.Log("Loaded");
			    }
}