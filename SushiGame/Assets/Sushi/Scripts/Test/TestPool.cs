using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPool : MonoBehaviour {

	public GameObject prefab;
	GameObject[] customerRef = new GameObject[5];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			Spawn ();
			for (int i = 0; i < 5; i++) {
				if (customerRef [i] == null) {
					Debug.Log ("null" + i);
				} else {
					Debug.Log ("spawn" + i);
				}
			}
		}

		if(Input.GetKeyDown(KeyCode.V)){
			Debug.Log ("v");
			Delete ();
		}
	}

	void Spawn()
	{
		for (int i = 0; i < 5; i++) {
			if(customerRef[i] == null)
			{
				customerRef [i] = GameObject.Instantiate (prefab);
				break;
			}
		}
	}
	void Delete()
	{
		int i = Random.Range (0,5);
		if (customerRef [i] != null)
			Destroy (customerRef [i]);

	}
}
