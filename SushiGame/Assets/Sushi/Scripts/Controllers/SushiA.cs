using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts{
	namespace Controllers{
		public class SushiA : ControllerSushi {



			public bool isDragging = false;

			// Use this for initialization
			void Start () {
			}
			
			// Update is called once per frame
			void Update(){

				RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

				if (Input.GetMouseButtonDown (0) && hit.collider != null) {
						Debug.Log (gameObject.name + " Item ");
						Debug.Log ("mouse down");

						isDragging = true;
					} 

				else if (Input.GetMouseButtonUp (0) && hit.collider != null) {
						Debug.Log ("mouse up");
						Destroy (gameObject);
						isDragging = false;
					}

				if (isDragging == true) {
						OnMouseDrag ();	
					}
			}

			void OnTriggerEnter2D(Collider2D other){
				
				if(other.gameObject.tag == "SushiB"){
					Debug.Log (" Destroy " + other.gameObject.name + " and Sushi ");
					Destroy (other.gameObject);
					Destroy (gameObject);
				}
			}
		}
	}
}