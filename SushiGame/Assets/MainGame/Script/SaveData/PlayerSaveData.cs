using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public struct PlayerSaveData  {

    public int Money;
    public FurnitureStatus Furnitue;
    public PlayerCookSkillUpgradeStatus CookingSkill;
    public CookingRecipe RecipeUnlock;

    public struct FurnitureStatus {

        public int SushibarSlotLV;
        
        public bool Table1On;
        public bool Table2On;
        public bool Table3On;
        public bool Table4On;
        public bool Table5On;
        public bool Table6On;
        public bool Table7On;
        public bool Table8On;

        public bool Table1Buy;
        public bool Table2Buy;
        public bool Table3Buy;
        public bool Table4Buy;
        public bool Table5Buy;
        public bool Table6Buy;
        public bool Table7Buy;
        public bool Table8Buy;

    }

    public struct PlayerCookSkillUpgradeStatus{

        public int CookingSpeedLV;
        public int CookingQualityLV;
        public int MultiCookingLV;

    }

    public struct CookingRecipe{

        public bool Sushi1Unlock;
        public bool Sushi2Unlock;
        public bool Sushi3Unlock;
        public bool Sushi4Unlock;
        public bool Sushi5Unlock;
        public bool SushiSet1Unlock;

        public bool Sushi6Unlock;
        public bool Sushi7Unlock;
        public bool Sushi8Unlock;
        public bool Sushi9Unlock;
        public bool Sushi10Unlock;
        public bool SushiSet2Unlock;
    }

}
