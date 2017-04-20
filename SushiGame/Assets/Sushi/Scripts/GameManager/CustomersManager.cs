using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts{
	namespace GameManager{
		public class CustomersManager : MonoBehaviour {

			public GameObject[] CustomersObj;
			public Transform[] PosCustomer;

			private int idCustomer;
			private float TimeSpawn = 5f;
			//private int idPosCustomer;
			private GameObject[] Customer_Reference = new GameObject[5];

			// Use this for initialization
			void Start(){
				InvokeRepeating ("Spawn",3f,5f);
			}
			
			// Update is called once per frame
			void Update () {
				TimeSpawn -= Time.deltaTime;
			}

			void Spawn(){
				for (int i = 0; i < 5; i++) {
					if (Customer_Reference [i] == null && TimeSpawn <= 0f) {
						idCustomer = Random.Range (0, CustomersObj.Length);
						Customer_Reference [i] = GameObject.Instantiate (CustomersObj [idCustomer], PosCustomer [i].transform.position, transform.rotation);
						Debug.Log ("idCustomer " + idCustomer);
						TimeSpawn = 5f;
					}
				}
			}
		}
	}
}