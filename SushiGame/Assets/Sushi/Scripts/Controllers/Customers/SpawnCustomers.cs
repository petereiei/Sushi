using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controllers;

namespace Scripts.Controllers.Customers{
	public class SpawnCustomers : MonoBehaviour {

		public GameObject[] Customers;
		public Transform[] CMpoints;
		public List<GameObject> CmPos;
		private int spwan;
		private int customers;
		private int count;

		// Use this for initialization
		void Start () {
			CmPos = new List<GameObject> ();
		}

		// Update is called once per frame
		void Update(){
			customers = Random.Range (0, Customers.Length);
			//spwan = Random.Range (0, CMpoints.Length);
			SpwanPoint ();

//			for(int i = 0; i < count; i++){
//				CmPos [i].transform.position = CMpoints[i].position;
//			}
		}

		void SpwanPoint(){
			if(count < CMpoints.Length){
				GameObject cm = Instantiate (Customers[customers],CMpoints[count].transform.position,Quaternion.identity);
				CmPos.Add (cm.gameObject);
				cm.name = Customers[customers].name;
				Debug.Log (CMpoints[count].name+ " Spawn " + cm.name);
				count++;
			}
		}
	}
}