using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShop : MonoBehaviour {

    public GameObject UIpopup;
    private bool UIpop = false;

    public void CloseClick()
    {
        if(UIpop == false)
        {
            UIpop = true;
            GameManeger.Timepasue = true;
            UIpopup.SetActive(true);
        }
        
    }

    public void CloseYesOnclick()
    {
        Application.LoadLevel("MainRestaurantManage");
        UIpop = false;
        UIpopup.SetActive(false);
        Save.SaveData();
    }

    public void CloseNoOnclick()
    {
        UIpop = false;
        GameManeger.Timepasue = true;
        UIpopup.SetActive(false);
    }

}
