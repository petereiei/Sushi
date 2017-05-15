using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controllers;
using UnityEngine.Audio;
using UnityEngine.UI;


public class CloseShop : MonoBehaviour {

	[SerializeField]
	AudioMixerGroup _bgmGroup;

	[SerializeField]
	AudioSource _myAudio;

	[SerializeField]
	Button[] buttonOnclick;

    public GameObject UIpopup;
	public GameObject Camera;
	public GameObject uiSushiset1;
	public GameObject uiSushiset2;
    private bool UIpop = false;


	public AudioClip _myClip;

	private float _timeClose = 1f;


	void Start (){
		_myAudio = GetComponent<AudioSource> ();
	}

	void Update(){

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

	IEnumerator myCloseYesOnclick(){
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
		Application.LoadLevel("MainRestaurantManage");
		UIpop = false;
		UIpopup.SetActive(false);
		Save.SaveData();

		buttonOnclick[1].interactable = true;
		buttonOnclick[0].interactable = true;
	}

    public void CloseYesOnclick()
    {
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myCloseYesOnclick ());
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
