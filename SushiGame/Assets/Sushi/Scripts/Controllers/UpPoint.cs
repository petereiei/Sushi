using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts{
	namespace Controllers{
		public class UpPoint : MonoBehaviour {

			void OnTriggerEnter2D(Collider2D other) {
				if(other.gameObject.tag == "Player"){
				Debug.Log ("eiei");
				}
			}
		}
	}
}
