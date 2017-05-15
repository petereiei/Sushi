using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class TimeSetButton : MonoBehaviour {

	[SerializeField]
	AudioMixerGroup _bgmGroup;

	[SerializeField]
	AudioSource _myAudio;

	[SerializeField]
	Button[] buttonOnclick;


	public AudioClip _myClip;

	private bool _myTaskOnClick2 = false;
	private bool _myTaskOnClick3 = false;
	private bool _myTaskOnClick4 = false;

	private float _timeTaskOnClick1 = 1f;
	private float _timeTaskOnClick2 = 1f;
	private float _timeTaskOnClick3 = 1f;
	private float _timeTaskOnClick4 = 1f;

    static public float time;

    GameObject MoneyTextObject;
    Text MoneyText;


	void Start (){
		_myAudio = GetComponent<AudioSource> ();
	}

	void Update(){
		if(_myTaskOnClick2 == true){
			_timeTaskOnClick2 -= Time.deltaTime;
		}if(_myTaskOnClick3 == true){
			_timeTaskOnClick3 -= Time.deltaTime;
		}if(_myTaskOnClick4 == true){
			_timeTaskOnClick4 -= Time.deltaTime;
		}

		if(_timeTaskOnClick1 <= 0){
			myTask1 ();
		}if(_timeTaskOnClick2 <= 0){
			myTask2 ();
		}if(_timeTaskOnClick3 <= 0){
			myTask3 ();
		}if(_timeTaskOnClick4 <= 0){
			myTask4 ();
		}
		
	}

	IEnumerator myTask1(){
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
		time = GameData.TimeChioce1;
		Debug.Log("Click");
		Timer.stop = false;
		GameManeger.TimeUp = false;
		Save.SaveData();
		SceneManager.LoadScene("OpenShop");
	}

	IEnumerator myTask2(){
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
		if (PlayerStatus.Money >= GameData.TimeChioce2Cost)
		{
			time = GameData.TimeChioce2;
			Debug.Log("Click");
			PlayerStatus.Money -= GameData.TimeChioce2Cost;
			Timer.stop = false;
			GameManeger.TimeUp = false;
			Save.SaveData();
			SceneManager.LoadScene("OpenShop");
			_myTaskOnClick2 = false;
		}
		else
		{
			Debug.Log("Not enough Money");
		}
	}

	IEnumerator myTask3(){
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
		if (PlayerStatus.Money >= GameData.TimeChioce3Cost)
		{
			time = GameData.TimeChioce3;
			Debug.Log("Click");
			PlayerStatus.Money -= GameData.TimeChioce3Cost;
			Timer.stop = false;
			GameManeger.TimeUp = false;
			Save.SaveData();
			SceneManager.LoadScene("OpenShop");
			_myTaskOnClick3 = false;
		}
		else
		{
			Debug.Log("Not enough Money");
		}
	}

	IEnumerator myTask4(){
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
		if (PlayerStatus.Money >= GameData.TimeChioce4Cost)
		{
			time = GameData.TimeChioce4;
			Debug.Log("Click");
			PlayerStatus.Money -= GameData.TimeChioce4Cost;
			Timer.stop = false;
			GameManeger.TimeUp = false;
			Save.SaveData();
			SceneManager.LoadScene("OpenShop");
			_myTaskOnClick4 = false;
		}
		else
		{
			Debug.Log("Not enough Money");
		}
	}

    public void TaskOnClick1()
    {
		buttonOnclick[4].interactable = false;
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myTask1 ());
        
    }

    public void TaskOnClick2()
    {
		buttonOnclick[4].interactable = false;
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myTask2 ());
    }

    public void TaskOnClick3()
    {
		buttonOnclick[4].interactable = false;
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myTask3 ());
    }

    public void TaskOnClick4()
    {
		buttonOnclick[4].interactable = false;
		buttonOnclick[3].interactable = false;
		buttonOnclick[2].interactable = false;
		buttonOnclick[1].interactable = false;
		buttonOnclick[0].interactable = false;
		StartCoroutine (myTask4 ());
    }

}
