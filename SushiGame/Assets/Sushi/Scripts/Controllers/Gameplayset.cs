using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts{
	namespace Controllers{
		public class Gameplayset : MonoBehaviour {

			public GameObject SushiSet1;
			public GameObject SushiSet2;


			// Use this for initialization
			void Start () {


			}
			
			// Update is called once per frame
			void Update () {

				if (MainHomeManager.SetSelect == 1) {
					SushiSet1.SetActive (true);
					SushiSet2.SetActive (false);
				} else if(MainHomeManager.SetSelect == 2){
					SushiSet2.SetActive (true);
					SushiSet1.SetActive (false);
				}

			}
		}
	}
}
