using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeSetButton : MonoBehaviour {

	AudioSource _myAudio;
	public AudioClip _myClip;

	private bool _myTaskOnClick1 = false;
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
		if(_myTaskOnClick1 == true){
			_timeTaskOnClick1 -= Time.deltaTime;
		}if(_myTaskOnClick2 == true){
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

	void myTask1(){
		time = GameData.TimeChioce1;
		Debug.Log("Click");
		Timer.stop = false;
		GameManeger.TimeUp = false;
		Save.SaveData();
		SceneManager.LoadScene("OpenShop");
		_myTaskOnClick1 = false;
	}

	void myTask2(){
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

	void myTask3(){
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

	void myTask4(){
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
		myTaskOnClick1 ();
        
    }

    public void TaskOnClick2()
    {
		myTaskOnClick2 (); 
    }

    public void TaskOnClick3()
    {
		myTaskOnClick3 ();
    }

    public void TaskOnClick4()
    {
		myTaskOnClick4 ();
    }

	void myTaskOnClick1(){
		_myAudio.Play ();
		_myTaskOnClick1 = true;
	}

	void myTaskOnClick2(){
		_myAudio.Play ();
		_myTaskOnClick2 = true;
	}

	void myTaskOnClick3(){
		_myAudio.Play ();
		_myTaskOnClick3 = true;
	}

	void myTaskOnClick4(){
		_myAudio.Play ();
		_myTaskOnClick4 = true;
	}

}
