using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LitJson;
using UnityEngine.Audio;

public class StartScreenManager : MonoBehaviour {

	AudioSource _myAudio;
	public AudioClip _myClip;
	public float _time = 1f;
	public bool _mytime = false;

	void Start (){
		_myAudio = GetComponent<AudioSource> ();
	}

	void Update(){
		if(_mytime == true){
			_time -= Time.deltaTime;
		}
		if(_time <= 0){
			StartGame ();
		}
	}



    public void GameStartOnClick()
    {
		myPlay ();
    }

	void myPlay(){
		_myAudio.PlayOneShot (_myClip);
		_mytime = true;
	}

	public void StartGame(){
		SceneManager.LoadScene("MainRestaurantManage");
		Load.LoadData();
	}
}
