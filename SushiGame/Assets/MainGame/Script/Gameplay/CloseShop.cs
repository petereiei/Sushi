using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controllers;

public class CloseShop : MonoBehaviour {

    public GameObject UIpopup;
	public GameObject Camera;
	public GameObject uiSushiset1;
	public GameObject uiSushiset2;
    private bool UIpop = false;


	void Start(){
	}

    public void CloseClick()
    {
        if(UIpop == false)
        {
            UIpop = true;
            GameManeger.Timepasue = true;
            UIpopup.SetActive(true);
			Camera.SetActive (false);
			if(MainHomeManager.SetSelect == 1){
				uiSushiset1.SetActive (false);
			}else if(MainHomeManager.SetSelect == 2){
				uiSushiset2.SetActive (false);
			}
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
		Camera.SetActive (true);
		if(MainHomeManager.SetSelect == 1){
			uiSushiset1.SetActive (true);
		}else if(MainHomeManager.SetSelect == 2){
			uiSushiset2.SetActive (true);
		}
    }
}
