using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controllers;
using Scripts.Controllers.Customers;

namespace Scripts{
	namespace Controllers{
		public class SushiA1 : ControllerSushi {

			private SpawnSushiB SSushib;
			private GameManeger _gm;
			private GameObject Sushi;
			private GameObject UISsushi;

			// Use this for initialization
			void Start () {
				Sushi = GameObject.Find ("Canvas");
				UISsushi = GameObject.Find ("Canvas/GameplayManager");
				_gm = UISsushi.GetComponent<GameManeger> ();
				SSushib = Sushi.GetComponent<SpawnSushiB>();
			}

			// Update is called once per frame
			void Update(){
			}

			void OnMouseDown (){
				RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
				if (Input.GetMouseButtonDown (0) && hit.collider != null) {
					Debug.Log (gameObject.name + " Item ");
					Debug.Log ("mouse down");
				} 
			}

			void OnMouseUp(){
				RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
				if (Input.GetMouseButtonUp (0) && hit.collider != null) {
					Debug.Log ("mouse up");
					Debug.Log ("Destroy sushi");
					SSushib.SushiObj.Remove (gameObject);
					Destroy (gameObject);
					SSushib.ReSushiCount();
					SSushib._myAudio.PlayOneShot (SSushib._myClipSushi[2]);
				}
			}

			void OnTriggerEnter2D(Collider2D other){
				if (other.gameObject.tag == "SushiA2") {
					Debug.Log (" Destroy " + other.gameObject.name + " and Customers ");
					SSushib.SushiObj.Remove (gameObject);
					Destroy (other.gameObject);
					Destroy (gameObject);
					SSushib._myAudio.PlayOneShot (SSushib._myClipSushi[1]);
					SSushib.ReSushiCount ();
					_gm.CustomerIncome ();
					_gm.SatisfyGetOrLoss ();
				}
				else {
					Debug.Log ("no Sushi");
				}
			}
		}
	}
}
