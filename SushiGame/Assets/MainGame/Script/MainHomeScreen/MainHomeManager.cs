using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainHomeManager : MonoBehaviour {


	[SerializeField]
	AudioMixerGroup _bgmGroup;

	[SerializeField]
	AudioSource _myAudio;

	[SerializeField]
	Button[] buttonOnclick;

	public AudioClip _myClip;

	[Header("Start Game Popup")]
    //StartGamePopUp 
    public GameObject StartGamePopupUI;
    public GameObject TimeSet;
    public GameObject Sushiset;

    public GameObject Black;


    //SushiSet
    public static int SetSelect = 1;
	[Header("Sushi Set")]
    public GameObject sushiset1;
    public GameObject sushiset2;
    public GameObject SetlockText;
    private bool SetLock = false;

	//Audio
	public AudioClip _myClipClick;

	void Start (){
		_bgmGroup.audioMixer.SetFloat ("BGMVolume", 0.0f);
	}

	void Update(){

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
		buttonOnclick[4].interactable = true;
		buttonOnclick[3].interactable = true;
		buttonOnclick[2].interactable = true;
		buttonOnclick[1].interactable = true;
		buttonOnclick[0].interactable = true;
		_myAudio.Play ();
        Black.SetActive(false);
        StartGamePopupUI.SetActive(false);
        TimeSet.SetActive(false);

    }


    //Menu
    public void FurnitureManageButtonOnclick()
    {
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myFurnitureManageButtonOnclick ());
    }

    public void RecipeUnlockButton()
    {
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myRecipeUnlockButton ());
    }

    public void CookUpgradeButton()
    {
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myCookUpgradeButton ());
    }

    public void HomeBtn()
	{
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myHomeBtn ());
    }

	IEnumerator myFurnitureManageButtonOnclick(){
		float lerp = 0;
		float _time = 1f;
		_myAudio.PlayOneShot (_myClip);
		while (_time > 0) {

			lerp = _time / 1f;
			_bgmGroup.audioMixer.SetFloat ("BGMVolume", Mathf.Lerp(-80.0f, 0.0f, lerp));
			yield return null;
			_time -= Time.deltaTime;
		}
		yield return null;
		Save.SaveData();
		SceneManager.LoadScene("FurnitureManagement");
	}

	IEnumerator myRecipeUnlockButton(){

		float lerp = 0;
		float _time = 1f;
		_myAudio.PlayOneShot (_myClip);
		while (_time > 0) {

			lerp = _time / 1f;
			_bgmGroup.audioMixer.SetFloat ("BGMVolume", Mathf.Lerp(-80.0f, 0.0f, lerp));
			yield return null;
			_time -= Time.deltaTime;
		}
		yield return null;
		Save.SaveData();
		SceneManager.LoadScene("RecipeUnlock");
	}

	IEnumerator myCookUpgradeButton(){
		float lerp = 0;
		float _time = 1f;
		_myAudio.PlayOneShot (_myClip);
		while (_time > 0) {

			lerp = _time / 1f;
			_bgmGroup.audioMixer.SetFloat ("BGMVolume", Mathf.Lerp(-80.0f, 0.0f, lerp));
			yield return null;
			_time -= Time.deltaTime;
		}
		yield return null;
		Save.SaveData();
		SceneManager.LoadScene("CookUpgrade");
	}

	IEnumerator myHomeBtn(){
		float lerp = 0;
		float _time = 1f;
		_myAudio.PlayOneShot (_myClip);
		while (_time > 0) {

			lerp = _time / 1f;
			_bgmGroup.audioMixer.SetFloat ("BGMVolume", Mathf.Lerp(-80.0f, 0.0f, lerp));
			yield return null;
			_time -= Time.deltaTime;
		}
		yield return null;
		SceneManager.LoadScene("StartGame");
	}		
}
