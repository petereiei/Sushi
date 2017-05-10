using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controllers;

namespace Scripts{
	namespace GameManager{
		public class CustomersManagerB : MonoBehaviour {

			public GameObject[] CustomersObjb;
			public Transform[] PosCustomer;

			private int idCustomer;
			private float TimeSpawn = 1.5f;
			//private int idPosCustomer;
			private GameObject[] Customer_Reference = new GameObject[8];

			AudioSource _myAudio;
			public AudioClip _myClipSushi;

			// Use this for initialization
			void Start(){
				_myAudio = GetComponent<AudioSource> ();
				InvokeRepeating ("Spawn",3f,5f);
			}

			// Update is called once per frame
			void Update () {
				TimeSpawn -= Time.deltaTime;
			}

			void Spawn(){
				for (int i = 0; i < TablePopUpUI.TableNumber; i++) {
					if (Customer_Reference [i] == null && TimeSpawn <= 0f) {
						idCustomer = Random.Range (0, CustomersObjb.Length);
						Customer_Reference [i] = GameObject.Instantiate (CustomersObjb [idCustomer], PosCustomer [i].transform.position, transform.rotation);
						_myAudio.Play ();
						Debug.Log ("idCustomer " + idCustomer);
						TimeSpawn = 1.5f;
					}
				}
			}
		}
	}
}
