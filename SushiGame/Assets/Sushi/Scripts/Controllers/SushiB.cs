using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts{
	namespace Controllers{
		public class SushiB : ControllerSushi {

			// Use this for initialization
			void Start () {
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
					Destroy (gameObject);
				}
			}

			void OnTriggerEnter2D(Collider2D other)
			{
				if(other.gameObject.tag == "SushiB")
				{
					Destroy (other.gameObject);
					Destroy (gameObject);
				}
			}
		}
	}
}
