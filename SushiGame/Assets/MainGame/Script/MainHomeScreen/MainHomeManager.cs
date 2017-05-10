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

	//Audio
	AudioSource _myAudio;
	public AudioClip _myClipClick;
	public bool _myHome = false;
	public bool _myCookUpgrade = false;
	public bool _myRecipeUnlock = false;
	public bool _myFurnitureManage = false;

	private float _timehome = 1f;
	private float _timeCookUpgrade = 1f;
	private float _timeRecipeUnlock = 1f;
	private float _timeFurnitureManage = 1f;

	void Start (){
		_myAudio = GetComponent<AudioSource> ();
	}

	void Update(){
		if(_myHome == true){
			_timehome -= Time.deltaTime;
		}if(_myCookUpgrade == true){
			_timeCookUpgrade -= Time.deltaTime;
		}if(_myRecipeUnlock == true){
			_timeRecipeUnlock -= Time.deltaTime;
		}if(_myFurnitureManage == true){
			_timeFurnitureManage -= Time.deltaTime;
		}


		if(_timehome <= 0){
			myHomeBtn ();
		}
		if(_timeCookUpgrade <= 0){
			myCookUpgradeButton ();
		}
		if(_timeRecipeUnlock <= 0){
			myRecipeUnlockButton ();
		}
		if(_timeFurnitureManage <= 0){
			myFurnitureManageButtonOnclick ();
		}
	}

    //StartGamePopUpButton
    public void StartGameOnclick() {
		_myAudio.Play ();
		Black.SetActive(true);
		StartGamePopupUI.SetActive(true);
		Sushiset.SetActive(true);
    }

    public void Set1Onclick()
    {
		_myAudio.Play ();
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
			_myAudio.Play ();
            SetLock = false;
            SetlockText.SetActive(false);
            SetSelect = 2;
            sushiset2.SetActive(true);
            sushiset1.SetActive(false);
        }
        else
        {
			_myAudio.Play ();
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
			_myAudio.Play ();
            Sushiset.SetActive(false);
            TimeSet.SetActive(true);
        }
        

    }

    public void StartGamePopupcloseOnclick()
    {
		_myAudio.Play ();
        Black.SetActive(false);
        StartGamePopupUI.SetActive(false);
        TimeSet.SetActive(false);

    }


    //Menu
    public void FurnitureManageButtonOnclick()
    {
		myFurnitureManage ();
    }

    public void RecipeUnlockButton()
    {
		myRecipeUnlock ();
    }

    public void CookUpgradeButton()
    {
		myCookUpgrade ();
    }

    public void HomeBtn()
	{
		myHome ();
    }

	void myFurnitureManageButtonOnclick(){
		Save.SaveData();
		SceneManager.LoadScene("FurnitureManagement");
		_myFurnitureManage = false;
	}

	void myRecipeUnlockButton(){
		Save.SaveData();
		SceneManager.LoadScene("RecipeUnlock");
		_myRecipeUnlock = false;
	}

	void myCookUpgradeButton(){
		Save.SaveData();
		SceneManager.LoadScene("CookUpgrade");
		_myCookUpgrade = false;
	}

	void myHomeBtn(){
		SceneManager.LoadScene("StartGame");
		_myHome = false;
	}

	void myFurnitureManage(){
		_myAudio.Play ();
		_myFurnitureManage = true;
	}

	void myRecipeUnlock(){
		_myAudio.Play ();
		_myRecipeUnlock = true;
	}

	void myCookUpgrade(){
		_myAudio.Play ();
		_myCookUpgrade = true;
	}

	void myHome(){
		_myAudio.Play ();
		_myHome = true;
	}
}
