using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using LitJson;
using UnityEngine.Audio;

public class StartScreenManager : MonoBehaviour {

	[SerializeField]
	AudioSource _bgm;

	[SerializeField]
	AudioSource _myAudio;

	[SerializeField]
	Button buttonStart;

	[SerializeField]
	AudioMixerGroup _bgmGroup;

	public AudioClip _myClip;

	void Start (){
		//_myAudio = GetComponent<AudioSource> ();
		_bgmGroup.audioMixer.SetFloat ("BGMVolume", 0.0f);
	}



    public void GameStartOnClick()
    {
		buttonStart.interactable = false;
		StartCoroutine (StartGame ());
    }

	IEnumerator StartGame()
	{
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
		SceneManager.LoadScene("MainRestaurantManage");
		Load.LoadData();
	}
}
