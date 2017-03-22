using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Scripts{
	namespace Controllers{
		public class ControllerSushi : MonoBehaviour {

			void Start(){				
			}

			void Updeta(){
			}

			public void OnMouseDrag(){
				//Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
				Vector2 objPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				transform.position = objPosition;
			}
		}
	}
}