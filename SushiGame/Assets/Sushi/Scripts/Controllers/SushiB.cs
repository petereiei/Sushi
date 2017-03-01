using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts{
	namespace Controllers{
		public class SushiB : ControllerSushi {

			public bool isDragging = false;

			// Use this for initialization
			void Start () {
			}

			// Update is called once per frame
			void Update(){
				if (Input.GetMouseButtonDown (0)) {
					Debug.Log ("mouse down");

					isDragging = true;
					if(isDragging){
						base.OnMouseDrag ();
					}
				}

				else if(Input.GetMouseButtonUp(0)){
					Debug.Log ("mouse up");

					isDragging = false;

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
