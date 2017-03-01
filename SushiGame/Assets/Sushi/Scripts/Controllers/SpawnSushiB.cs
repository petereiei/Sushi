using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts{
	namespace Controllers{
		public class SpawnSushiB : MonoBehaviour {

			public GameObject SushisB;
			public Transform SushiPosB;

			void Start () {
			}

			// Update is called once per frame
			public void SushiUp () {
				
				Instantiate (SushisB,SushiPosB.position,SushiPosB.rotation);
			}
		}
	}
}
