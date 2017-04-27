using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Scripts{
	namespace Controllers{
public class SpawnSushi : MonoBehaviour {

			public GameObject[] Sushia;
			public Transform[] SushiPos;
			public List<GameObject> SushiObj;
			public Image[] _uiSushiCool;
			private GameObject sushi;
			//private GameObject _sushiset;


			public int SushiCount = 0;
			private float counter = 0;
			private float counterb = 0;
			private float counterC = 0;
			private float counterD = 0;
			private float counterE = 0;

			// Use this for initialization
			void Start (){
				//SushiPons = new List<Transform>();
				SushiObj = new List<GameObject> ();
				//_sushiset = GameObject.Find ("Canvas/tabs/tab1");
			}

			void Update(){
				
				counter -= Time.deltaTime;
				counterb -= Time.deltaTime;
				counterC -= Time.deltaTime;
				counterD -= Time.deltaTime;
				counterE -= Time.deltaTime;


				_uiSushiCool [0].fillAmount = counter;
				_uiSushiCool [1].fillAmount = counterb;
				_uiSushiCool [2].fillAmount = counterC;
				_uiSushiCool [3].fillAmount = counterD;
				_uiSushiCool [4].fillAmount = counterE;

			}

			public void ReSushiCount(){
				SushiCount--;

				for(int i = 0; i < SushiCount; i++){
					SushiObj [i].transform.position = SushiPos [i].position;
				}
			}
				
			public void SushiAUp () {
				
				if(Sushia != null){
					if(counter <= 0 && SushiCount <= 3){
						if (SushiCount < SushiPos.Length) {
							sushi = Instantiate (Sushia [0], SushiPos[SushiCount].transform.position, Quaternion.identity);		
							SushiObj.Add (sushi.gameObject);
							//sushi.transform.SetParent (_sushiset.transform);
							SushiCount++;
							sushi.name = Sushia [0].name;
							Debug.Log (sushi.name);
							//Debug.Log (SushiPos [SushiCount].name);
							counter = 1;
						}
					}
				}
			}

			public void SushiBUp () {

				if(Sushia != null){
					if (counterb <= 0 && SushiCount <= 3) {
						//Debug.Log ("SushiB time 0 ");
						if (SushiCount < SushiPos.Length) {
							sushi = Instantiate (Sushia [1], SushiPos[SushiCount].transform.position, Quaternion.identity);
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [1].name;
							Debug.Log (sushi.name);
							//Debug.Log (SushiPos[SushiCount].name);
							counterb = 1;
						}
					}
				}
			}

			public void SushiCUp () {

				if (Sushia != null) {
					if (counterC <= 0 && SushiCount <= 3) {
						//Debug.Log ("SushiC time 0 ");
						if (SushiCount < SushiPos.Length) {
							sushi = Instantiate (Sushia [2], SushiPos[SushiCount].transform.position, Quaternion.identity);
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [2].name;
							Debug.Log (sushi.name);
							//Debug.Log (SushiPos [SushiCount].name);
							counterC = 1;
						}
					}
				}
			}

			public void SushiDUp () {

				if (Sushia != null) {
					if (counterD <= 0 && SushiCount <= 3) {
						//Debug.Log ("SushiD time 0 ");
						if (SushiCount < SushiPos.Length) {
							sushi = Instantiate (Sushia [3], SushiPos[SushiCount].transform.position, Quaternion.identity);
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [3].name;
							Debug.Log (sushi.name);
//							Debug.Log (SushiPos [SushiCount].name);
							counterD = 1;
						}
					}
				}
			}

			public void SushiEUp () {

				if (Sushia != null) {
					if (counterE <= 0 && SushiCount <= 3) {
						//Debug.Log ("SushiE time 0 ");
						if (SushiCount < SushiPos.Length) {
							sushi = Instantiate (Sushia [4], SushiPos[SushiCount].transform.position, Quaternion.identity);
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [4].name;
							Debug.Log (sushi.name);
							//Debug.Log (SushiPos [SushiCount].name);
							counterE = 1;
						}
					}
				}
			}
		}
	}
}