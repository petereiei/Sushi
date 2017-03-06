using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Controllers.Customers{
	public class SpawnCustomers : MonoBehaviour {

		public GameObject[] Customers;
		public Transform[] CMpoints;
		private int spwan;
		private int customers;
		private int count;

		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update(){
			customers = Random.Range (0, Customers.Length);
			SpwanPoint ();
		}

		void SpwanPoint(){
			if(count < CMpoints.Length){
				GameObject cm = Instantiate (Customers[customers],CMpoints[count].transform.position,Quaternion.identity);
				count++;
				cm.name = Customers[customers].name;
				Debug.Log (cm.name);
			}//spwan = Random.Range (0, CMpoints.Length);
		}
	}
}