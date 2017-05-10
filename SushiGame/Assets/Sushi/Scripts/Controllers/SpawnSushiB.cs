using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts{
	namespace Controllers{
		public class SpawnSushiB : MonoBehaviour {

			public GameObject[] Sushia;
			public Transform[] SushiPos;
			public List<GameObject> SushiObj;
			private GameObject sushi;
			public Image[] _uiSushiCoolB;

			public int SushiCount = 0;
			private int SushiSetCount;
			private float counter = 0;
			private float counterb = 0;
			private float counterC = 0;
			private float counterD = 0;
			private float counterE = 0;

			private int _multiSushiA;
			private int _multiSushiB;
			private int _multiSushiC;
			private int _multiSushiD;
			private int _multiSushiE;

			public int _multi;

			AudioSource _myAudio;
			public AudioClip _myClipSushi;

			// Use this for initialization
			void Start (){

				_myAudio = GetComponent<AudioSource> ();

				//SushiObj = new List<GameObject> ();

				if(PlayerStatus.SushibarSlotLV == 0){
					SushiSetCount = 0;
				}if(PlayerStatus.SushibarSlotLV == 1){
					SushiSetCount = 1;
				}if(PlayerStatus.SushibarSlotLV == 2){
					SushiSetCount = 2;
				}if(PlayerStatus.SushibarSlotLV == 3){
					SushiSetCount = 3;
				}if(PlayerStatus.SushibarSlotLV == 4){
					SushiSetCount = 4;
				}

				if(PlayerStatus.MultiCookingLV == 0){
					_multi = 0;
				}if(PlayerStatus.MultiCookingLV == 1){
					_multi = 1;
				}if(PlayerStatus.MultiCookingLV == 2){
					_multi = 2;
				}if(PlayerStatus.MultiCookingLV == 3){
					_multi = 3;
				}if(PlayerStatus.MultiCookingLV == 4){
					_multi = 4;
				}
			}

			void Update(){
				counter -= Time.deltaTime;
				counterb -= Time.deltaTime;
				counterC -= Time.deltaTime;
				counterD -= Time.deltaTime;
				counterE -= Time.deltaTime;

				_uiSushiCoolB [0].fillAmount = counter;
				_uiSushiCoolB [1].fillAmount = counterb;
				_uiSushiCoolB [2].fillAmount = counterC;
				_uiSushiCoolB [3].fillAmount = counterD;
				_uiSushiCoolB [4].fillAmount = counterE;
			}

			public void ReSushiCount(){
				SushiCount--;

				for(int i = 0; i < SushiCount; i++){
					SushiObj [i].transform.position = SushiPos [i].position;
					_myAudio.PlayOneShot (_myClipSushi);
				}
			}

			public void SushiAUp () {

				if(Sushia != null){
					if(counter <= 0 && SushiCount <= SushiSetCount){
						if (SushiCount < SushiPos.Length) {
							_myAudio.Play ();
							sushi = Instantiate (Sushia [0], SushiPos[SushiCount].transform.position, Quaternion.identity);		
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [0].name;
							Debug.Log (sushi.name);
							if(_multiSushiA == _multi){
								if(PlayerStatus.CookingSpeedLV == 1){
									Debug.Log ("Speed LV 1");
									counter = 2f;
									_multiSushiA = 0;
								}if(PlayerStatus.CookingSpeedLV == 2){
									Debug.Log ("Speed LV 2");
									counter = 1.5f;
									_multiSushiA = 0;
								}if(PlayerStatus.CookingSpeedLV == 3){
									Debug.Log ("Speed LV 3");
									counter = 1f;
									_multiSushiA = 0;
								}if (PlayerStatus.CookingSpeedLV == 4) {
									Debug.Log ("Speed LV 4");
									counter = 0.5f;
									_multiSushiA = 0;
								}else{
									Debug.Log ("Speed LV 2.5");
									counter = 2.5f;
									_multiSushiA = 0;
								}
							}else {
								Debug.Log ("Speed 0");
								counter = 0f;
								_multiSushiA++;
							}
						}
					}
				}
			}

			public void SushiBUp () {

				if(Sushia != null){
					if (counterb <= 0 && SushiCount <= SushiSetCount) {
						if (SushiCount < SushiPos.Length) {
							_myAudio.Play ();
							sushi = Instantiate (Sushia [1], SushiPos[SushiCount].transform.position, Quaternion.identity);
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [1].name;
							Debug.Log (sushi.name);
							if(_multiSushiB == _multi){
								if(PlayerStatus.CookingSpeedLV == 1){
									Debug.Log ("Speed LV 1");
									counterb = 2f;
									_multiSushiB = 0;
								}if(PlayerStatus.CookingSpeedLV == 2){
									Debug.Log ("Speed LV 2");
									counterb = 1.5f;
									_multiSushiB = 0;
								}if(PlayerStatus.CookingSpeedLV == 3){
									Debug.Log ("Speed LV 3");
									counterb = 1f;
									_multiSushiB = 0;
								}if (PlayerStatus.CookingSpeedLV == 4) {
									Debug.Log ("Speed LV 4");
									counterb = 0.5f;
									_multiSushiB = 0;
								}else{
									Debug.Log ("Speed LV 2.5");
									counterb = 2.5f;
									_multiSushiB = 0;
								}
							}else {
								Debug.Log ("Speed 0");
								counterb = 0f;
								_multiSushiB++;
							}
						}
					}
				}
			}

			public void SushiCUp () {

				if (Sushia != null) {
					if (counterC <= 0 && SushiCount <= SushiSetCount) {
						if (SushiCount < SushiPos.Length) {
							_myAudio.Play ();
							sushi = Instantiate (Sushia [2], SushiPos[SushiCount].transform.position, Quaternion.identity);
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [2].name;
							Debug.Log (sushi.name);
							if(_multiSushiC == _multi){
								if(PlayerStatus.CookingSpeedLV == 1){
									Debug.Log ("Speed LV 1");
									counterC = 2f;
									_multiSushiC = 0;
								}if(PlayerStatus.CookingSpeedLV == 2){
									Debug.Log ("Speed LV 2");
									counterC = 1.5f;
									_multiSushiC = 0;
								}if(PlayerStatus.CookingSpeedLV == 3){
									Debug.Log ("Speed LV 3");
									counterC = 1f;
									_multiSushiC = 0;
								}if (PlayerStatus.CookingSpeedLV == 4) {
									Debug.Log ("Speed LV 4");
									counterC = 0.5f;
									_multiSushiC = 0;
								}else{
									Debug.Log ("Speed LV 2.5");
									counterC = 2.5f;
									_multiSushiC = 0;
								}
							}else {
								Debug.Log ("Speed 0");
								counterC = 0f;
								_multiSushiC++;
							}
						}
					}
				}
			}

			public void SushiDUp () {

				if (Sushia != null) {
					if (counterD <= 0 && SushiCount <= SushiSetCount) {
						if (SushiCount < SushiPos.Length) {
							_myAudio.Play ();
							sushi = Instantiate (Sushia [3], SushiPos[SushiCount].transform.position, Quaternion.identity);
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [3].name;
							Debug.Log (sushi.name);
							if(_multiSushiD == _multi){
								if(PlayerStatus.CookingSpeedLV == 1){
									Debug.Log ("Speed LV 1");
									counterD = 2f;
									_multiSushiD = 0;
								}if(PlayerStatus.CookingSpeedLV == 2){
									Debug.Log ("Speed LV 2");
									counterD = 1.5f;
									_multiSushiD = 0;
								}if(PlayerStatus.CookingSpeedLV == 3){
									Debug.Log ("Speed LV 3");
									counterD = 1f;
									_multiSushiD = 0;
								}if (PlayerStatus.CookingSpeedLV == 4) {
									Debug.Log ("Speed LV 4");
									counterD = 0.5f;
									_multiSushiD = 0;
								}else{
									Debug.Log ("Speed LV 2.5");
									counterD = 2.5f;
									_multiSushiD = 0;
								}
							}else {
								Debug.Log ("Speed 0");
								counterD = 0f;
								_multiSushiD++;
							}
						}
					}
				}
			}

			public void SushiEUp () {

				if (Sushia != null) {
					if (counterE <= 0 && SushiCount <= SushiSetCount) {
						if (SushiCount < SushiPos.Length) {
							_myAudio.Play ();
							sushi = Instantiate (Sushia [4], SushiPos[SushiCount].transform.position, Quaternion.identity);
							SushiObj.Add (sushi.gameObject);
							SushiCount++;
							sushi.name = Sushia [4].name;
							Debug.Log (sushi.name);
							if(_multiSushiE == _multi){
								if(PlayerStatus.CookingSpeedLV == 1){
									Debug.Log ("Speed LV 1");
									counterE = 2f;
									_multiSushiE = 0;
								}if(PlayerStatus.CookingSpeedLV == 2){
									Debug.Log ("Speed LV 2");
									counterE = 1.5f;
									_multiSushiE = 0;
								}if(PlayerStatus.CookingSpeedLV == 3){
									Debug.Log ("Speed LV 3");
									counterE = 1f;
									_multiSushiE = 0;
								}if (PlayerStatus.CookingSpeedLV == 4) {
									Debug.Log ("Speed LV 4");
									counterE = 0.5f;
									_multiSushiE = 0;
								}else{
									Debug.Log ("Speed LV 2.5");
									counterE = 2.5f;
									_multiSushiE = 0;
								}
							}else {
								Debug.Log ("Speed 0");
								counterE = 0f;
								_multiSushiE++;
							}
						}
					}
				}
			}
		}
	}
}
