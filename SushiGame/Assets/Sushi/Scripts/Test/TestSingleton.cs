using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingleton : MonoBehaviour {

	private static TestSingleton _instance;
	public static TestSingleton instance{
		get { return _instance;}
		set { _instance = value; }
	}
	int i;
	public int index;
	int foodset;

	void Awake(){
		if (instance != null)
			Destroy (gameObject);
		else {
			instance = this;
			instance.i = this.index;
			DontDestroyOnLoad (gameObject);
		}
	}

//	public void SetFood(int _i)
//	{
//		foodset = _i;
//	}
//	public void GetFood()
//	{
//		return foodset;
//	}
	public void PrintString()
	{
		Debug.Log ("LOG" + instance.i);
	}
}
