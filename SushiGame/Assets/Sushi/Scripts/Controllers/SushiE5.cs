﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controllers;
using Scripts.Controllers.Customers;

namespace Scripts{
	namespace Controllers{
		public class SushiE5 : ControllerSushi {

			private SpawnSushiB SSushi;
			private GameObject Sushi;

			// Use this for initialization
			void Start () {
				Sushi = GameObject.Find ("Canvas");
				SSushi = Sushi.GetComponent<SpawnSushiB>();
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
				if (other.gameObject.tag == "SushiE2") {
					Debug.Log (" Destroy " + other.gameObject.name + " and Customers ");
					SSushi.SushiObj.Remove (gameObject);
					Destroy (other.gameObject);
					Destroy (gameObject);
					SSushi.ReSushiCount ();
				}
				else {
					Debug.Log ("no Sushi");
				}
			}
		}
	}
}