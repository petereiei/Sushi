using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.Controllers.Customers{
	public class SpawnCustomers : MonoBehaviour {

		public GameObject[] Customers;
		public Transform[] CMpoints;
		private int spwan;
		private int customers;
		private int count = 0;
		//private int i = 0;

		// Use this for initialization
		void Start () {
			//InvokeRepeating ("Spwan",2,2);
		}
			
		// Update is called once per frame
		void Update(){
		
			//if(CMpoints != null){

				customers = Random.Range (0, Customers.Length);
				SpwanPoint ();

			//	if(CMpoints != null){
			//		spwan = Random.Range (0, CMpoints.Length);
			//	}
				//spwan = Random.Range (0, CMpoints.Length);

			//}
		}

		void SpwanPoint(){

			if(count < CMpoints.Length){

				GameObject cm = Instantiate (Customers[customers],CMpoints[count].transform.position,Quaternion.identity);
				count++;

				cm.name = Customers[customers].name;
				Debug.Log (cm.name);
			}

			//spwan = Random.Range (0, CMpoints.Length);
		}


		//void Spwan () {


			//SpwanPoint ();


			//if(cm <= 3){
			//for(count = 0; count < Customers.Length; count++){
				//spwan = Random.Range (0, CMpoints.Length);
				//cm = Random.Range (0, Customers.Length);
				//SpwanPoint ();
			//	cm++;
			//	}
		//	}
			//spwan = Random.Range (0, CMpoints.Length);
			//cm = Random.Range (0, Customers.Length);
		//}


	}
}
