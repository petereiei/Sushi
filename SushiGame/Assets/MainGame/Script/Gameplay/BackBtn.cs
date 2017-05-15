using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BackBtn : MonoBehaviour {

	[SerializeField]
	AudioMixerGroup _bgmGroup;

	[SerializeField]
	AudioSource _myAudio;

	[SerializeField]
	Button[] buttonOnclick;

	public AudioClip _myClipSushi;

	void Start (){
	}

	void Update(){
	}

	IEnumerator myBackToHomeOnclick(){
		float lerp = 0;
		float _time = 1f;
		_myAudio.PlayOneShot (_myClipSushi);
		while (_time > 0) {

			lerp = _time / 1f;
			_bgmGroup.audioMixer.SetFloat ("BGMVolume", Mathf.Lerp(-80.0f, 0.0f, lerp));
			yield return null;
			_time -= Time.deltaTime;
		}
		yield return null;
		TablePopUpUI.TableUIShow = false;
		BarPopUpUI.BarUIShow = false;

		Save.SaveData();

		SceneManager.LoadScene("MainRestaurantManage");
	}

	public void BackToHomeOnclick()
    {

		buttonOnclick[9].interactable = false;
		buttonOnclick[8].interactable = false;
		buttonOnclick[7].interactable = false;
		buttonOnclick[6].interactable = false;
		buttonOnclick[5].interactable = false;
		buttonOnclick[4].interactable = false;
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myBackToHomeOnclick ());
    }
}
