using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCall : MonoBehaviour {

	void Start()
	{
//		TestSingleton.instance.SetFood (2);
//		TestSingleton.instance.GetFood ();
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
			TestSingleton.instance.PrintString ();
	}
}
