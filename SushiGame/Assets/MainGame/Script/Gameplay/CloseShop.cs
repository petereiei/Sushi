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


	AudioSource _myAudio;
	public AudioClip _myClip;
	private bool _myClose = false;

	private float _timeClose = 1f;


	void Start (){
		_myAudio = GetComponent<AudioSource> ();
	}

	void Update(){
		if(_myClose == true){
			_timeClose -= Time.deltaTime;
		}

		if(_timeClose <= 0){
			myCloseYesOnclick ();
		}
	}

    public void CloseClick()
    {
        if(UIpop == false)
        {
			_myAudio.Play ();
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

	void myCloseYesOnclick(){
		Application.LoadLevel("MainRestaurantManage");
		UIpop = false;
		UIpopup.SetActive(false);
		Save.SaveData();
	}

    public void CloseYesOnclick()
    {
		myClose ();
    }

	void myClose(){
		_myAudio.Play ();
		_myClose = true;
	}


    public void CloseNoOnclick()
    {
		_myAudio.Play ();
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
