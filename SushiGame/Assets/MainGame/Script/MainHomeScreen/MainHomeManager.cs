using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainHomeManager : MonoBehaviour {


    //StartGamePopUp 
    public GameObject StartGamePopupUI;
    public GameObject TimeSet;
    public GameObject Sushiset;

    public GameObject Black;


    //SushiSet
    public static int SetSelect = 1;
    public GameObject sushiset1;
    public GameObject sushiset2;
    public GameObject SetlockText;
    private bool SetLock = false;


    //StartGamePopUpButton
    public void StartGameOnclick() {

        Black.SetActive(true);
        StartGamePopupUI.SetActive(true);
        Sushiset.SetActive(true);

    }

    public void Set1Onclick()
    {

            SetLock = false;
            SetlockText.SetActive(false);
            SetSelect = 1;
            sushiset1.SetActive(true);
            sushiset2.SetActive(false);
 
    }
    public void Set2Onclick()
    {
        if(PlayerStatus.SushiSet2Unlock == true)
        {
            SetLock = false;
            SetlockText.SetActive(false);
            SetSelect = 2;
            sushiset2.SetActive(true);
            sushiset1.SetActive(false);
        }
        else
        {
            SetLock = true;
            SetlockText.SetActive(true);
            sushiset2.SetActive(true);
            sushiset1.SetActive(false);
        }


        
    }



    public void SetSushiNextOnclick()
    {
        if(SetLock == false)
        {
            Sushiset.SetActive(false);
            TimeSet.SetActive(true);
        }
        

    }

    public void StartGamePopupcloseOnclick()
    {
        Black.SetActive(false);
        StartGamePopupUI.SetActive(false);
        TimeSet.SetActive(false);

    }


    //Menu
    public void FurnitureManageButtonOnclick()
    {
        Save.SaveData();
        SceneManager.LoadScene("FurnitureManagement");
    }

    public void RecipeUnlockButton()
    {
        Save.SaveData();
        SceneManager.LoadScene("RecipeUnlock");
    }

    public void CookUpgradeButton()
    {
        Save.SaveData();
        SceneManager.LoadScene("CookUpgrade");
    }

    public void HomeBtn()
    {
        SceneManager.LoadScene("StartGame");
    }


}
