using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts{
	namespace Controllers{
public class SpawnSushi : MonoBehaviour {

			public GameObject[] SushiA;
			public Transform SushiPos;

			private float counter = 0;
			private float counterb = 0;
			private float counterC = 0;
			private float counterD = 0;
			private float counterE = 0;

			// Use this for initialization
			void Start (){
			}

			void Update(){
				counter -= Time.deltaTime;
				counterb -= Time.deltaTime;
				counterC -= Time.deltaTime;
				counterD -= Time.deltaTime;
				counterE -= Time.deltaTime;

			}
			// Update is called once per frame
			public void SushiAUp () {

				if(SushiA != null){
					if(counter <= 0){
						GameObject sushi = Instantiate (SushiA[0],SushiPos.position,SushiPos.rotation);
						sushi.name = SushiA [0].name;
						Debug.Log (sushi.name);
						counter = 3;
					}
				}
			}

			public void SushiBUp () {

				if(SushiA != null){
					if (counterb <= 0) {
						GameObject sushi = Instantiate (SushiA[1], SushiPos.position, SushiPos.rotation);
						sushi.name = SushiA [1].name;
						Debug.Log (sushi.name);
						counterb = 4;
					}
				}
			}

			public void SushiCUp () {

				if (SushiA != null) {
					if (counterC <= 0) {
						GameObject sushi = Instantiate (SushiA[2], SushiPos.position, SushiPos.rotation);
						sushi.name = SushiA [2].name;
						Debug.Log (sushi.name);
						counterC = 5;
					}
				}
			}

			public void SushiDUp () {

				if (SushiA != null) {
					if (counterD <= 0) {
						GameObject sushi = Instantiate (SushiA[3], SushiPos.position, SushiPos.rotation);
						sushi.name = SushiA [3].name;
						Debug.Log (sushi.name);
						counterD = 2;
					}
				}
			}

			public void SushiEUp () {

				if (SushiA != null) {
					if (counterE <= 0) {
						GameObject sushi = Instantiate (SushiA[4], SushiPos.position, SushiPos.rotation);
						sushi.name = SushiA [4].name;
						Debug.Log (sushi.name);
						counterE = 5;
					}
				}
			}
		}
	}
}
