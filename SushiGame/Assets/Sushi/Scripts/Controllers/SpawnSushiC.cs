using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts{
	namespace Controllers{
		public class SpawnSushiC : MonoBehaviour {

			public GameObject SushisC;
			public Transform SushiPosC;

			void Start () {
			}

			// Update is called once per frame
			public void SushiUp () {

				Instantiate (SushisC,SushiPosC.position,SushiPosC.rotation);
			}
		}
	}
}
