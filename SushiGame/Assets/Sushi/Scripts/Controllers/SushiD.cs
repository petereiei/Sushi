using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts{
	namespace Controllers{
		public class SushiD : ControllerSushi {

			private SpawnSushi SSushi;
			private GameManeger _gm;
			private GameObject Sushi;
			private GameObject UISsushi;

			// Use this for initialization
			void Start () {
				Sushi = GameObject.Find ("Canvas");
				UISsushi = GameObject.Find ("Canvas/GameplayManager");
				_gm = UISsushi.GetComponent<GameManeger> ();
				SSushi = Sushi.GetComponent<SpawnSushi>();
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
					SSushi.SushiObj.Remove (gameObject);
					Destroy (gameObject);
					SSushi.ReSushiCount();
				}
			}

			void OnTriggerEnter2D(Collider2D other){
				if (other.gameObject.tag == "SushiD") {
					Debug.Log (" Destroy " + other.gameObject.name + " and Customers ");
					SSushi.SushiObj.Remove (gameObject);
					Destroy (other.gameObject);
					Destroy (gameObject);
					SSushi._myAudio.PlayOneShot (SSushi._myClipSushi);
					SSushi.ReSushiCount ();
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
