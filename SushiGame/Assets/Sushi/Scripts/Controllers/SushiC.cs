using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts{
	namespace Controllers{
		public class SushiC : ControllerSushi {

			// Use this for initialization
			void Start () {
				
			}
			
			// Update is called once per frame
			void MoveSushiC () {
				OnMouseDrag ();
			}

			void OnCollisionEnter2D(Collision2D other)
			{
				if(other.gameObject.tag == "SushiC")
				{
					Destroy (gameObject);
				}
			}
		}
	}
}
