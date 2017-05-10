using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour {

	AudioSource _myAudio;
	public AudioClip _myClipSushi;

	private float _mytimeback = 1f;
	private bool _mybacktohome = false;

	void Start (){
		_myAudio = GetComponent<AudioSource> ();
	}

	void Update(){
		if(_mybacktohome == true){
			_mytimeback -= Time.deltaTime;
		}

		if(_mytimeback <= 0){
			myBackToHomeOnclick ();
		}
	}

	void myBackToHomeOnclick(){
		TablePopUpUI.TableUIShow = false;
		BarPopUpUI.BarUIShow = false;

		Save.SaveData();

		SceneManager.LoadScene("MainRestaurantManage");
		_mybacktohome = false;
	}

	public void BackToHomeOnclick()
    {
		myBackToHome ();
    }

	void myBackToHome(){
		_myAudio.Play ();
		_mybacktohome = true;
	}
}
