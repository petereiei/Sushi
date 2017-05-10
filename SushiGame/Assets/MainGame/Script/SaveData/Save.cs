using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public static class Save  {

	static public void SaveData()
    {
        PlayerSaveData player = new PlayerSaveData();
        player.Money = PlayerStatus.Money;

        player.Furnitue.SushibarSlotLV = PlayerStatus.SushibarSlotLV;



        player.Furnitue.Table1On = PlayerStatus.Table1On;
        player.Furnitue.Table2On = PlayerStatus.Table2On;
        player.Furnitue.Table3On = PlayerStatus.Table3On;
        player.Furnitue.Table4On = PlayerStatus.Table4On;
        player.Furnitue.Table5On = PlayerStatus.Table5On;
        player.Furnitue.Table6On = PlayerStatus.Table6On;
        player.Furnitue.Table7On = PlayerStatus.Table7On;
        player.Furnitue.Table8On = PlayerStatus.Table8On;

        player.Furnitue.Table1Buy = PlayerStatus.Table1Buy;
        player.Furnitue.Table2Buy = PlayerStatus.Table2Buy;
        player.Furnitue.Table3Buy = PlayerStatus.Table3Buy;
        player.Furnitue.Table4Buy = PlayerStatus.Table4Buy;
        player.Furnitue.Table5Buy = PlayerStatus.Table5Buy;
        player.Furnitue.Table6Buy = PlayerStatus.Table6Buy;
        player.Furnitue.Table7Buy = PlayerStatus.Table7Buy;
        player.Furnitue.Table8Buy = PlayerStatus.Table8Buy;

        player.CookingSkill.CookingQualityLV = PlayerStatus.CookingQualityLV;
        player.CookingSkill.CookingSpeedLV = PlayerStatus.CookingSpeedLV;
        player.CookingSkill.MultiCookingLV = PlayerStatus.MultiCookingLV;

        player.RecipeUnlock.Sushi1Unlock = PlayerStatus.Sushi1Unlock;
        player.RecipeUnlock.Sushi2Unlock = PlayerStatus.Sushi2Unlock;
        player.RecipeUnlock.Sushi3Unlock = PlayerStatus.Sushi3Unlock;
        player.RecipeUnlock.Sushi4Unlock = PlayerStatus.Sushi4Unlock;
        player.RecipeUnlock.Sushi5Unlock = PlayerStatus.Sushi5Unlock;
        player.RecipeUnlock.SushiSet1Unlock = PlayerStatus.SushiSet1Unlock;

        player.RecipeUnlock.Sushi6Unlock = PlayerStatus.Sushi6Unlock;
        player.RecipeUnlock.Sushi7Unlock = PlayerStatus.Sushi7Unlock;
        player.RecipeUnlock.Sushi8Unlock = PlayerStatus.Sushi8Unlock;
        player.RecipeUnlock.Sushi9Unlock = PlayerStatus.Sushi9Unlock;
        player.RecipeUnlock.Sushi10Unlock = PlayerStatus.Sushi10Unlock;
        player.RecipeUnlock.SushiSet2Unlock = PlayerStatus.SushiSet2Unlock;



        string json = JsonMapper.ToJson(player);
        PlayerPrefs.SetString("PlayerSaveData", json);
        Debug.Log("Saved");
    }

}
