using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts{
	namespace ItemUpgrade{
		public class ItemUp : MonoBehaviour {

			private string SushiPosA = "SushiUpA";
			private string SushiPosB = "SushiUpB";
			private string SushiPosC = "SushiUpC";
			private string SushiPosD = "SushiUpD";
			private string SushiPosE = "SushiUpE";
			private string SushiPosF = "SushiUpF";
			private bool UpgradeOn = true;

			public GameObject[] spider;
			public int _sushiUpPos = 1;


			// Use this for initialization
			void Start () {
				
			}
			
			// Update is called once per frame
			void Update () {
			}

			public void UpgradeSushiA(){
				if(UpgradeOn == true){
					PlayerPrefs.SetInt (SushiPosA, _sushiUpPos);
					Debug.Log (PlayerPrefs.GetInt(SushiPosA).ToString());
					spider[0].SetActive (false);
				}
			}

			public void UpgradeSushiB(){
				PlayerPrefs.SetInt (SushiPosB, _sushiUpPos);
				Debug.Log (PlayerPrefs.GetInt(SushiPosB).ToString());
				spider[1].SetActive (false);
			}

			public void UpgradeSushiC(){
				PlayerPrefs.SetInt (SushiPosC, _sushiUpPos);
				Debug.Log (PlayerPrefs.GetInt(SushiPosC).ToString());
				spider[2].SetActive (false);
			}

			public void UpgradeSushiD(){
				PlayerPrefs.SetInt (SushiPosD, _sushiUpPos);
				Debug.Log (PlayerPrefs.GetInt(SushiPosD).ToString());
				spider[3].SetActive (false);
			}

			public void UpgradeSushiE(){
				PlayerPrefs.SetInt (SushiPosE, _sushiUpPos);
				Debug.Log (PlayerPrefs.GetInt(SushiPosE).ToString());
				spider[4].SetActive (false);
			}

			public void UpgradeSushiF(){
				PlayerPrefs.SetInt (SushiPosF, _sushiUpPos);
				Debug.Log (PlayerPrefs.GetInt(SushiPosF).ToString());
				spider[5].SetActive (false);
			}

//			public void l(){
//				_sushiUpPos = PlayerPrefs.GetInt (SushiPosA,0);
//				_sushiUpPos = PlayerPrefs.GetInt (SushiPosB,0);
//				_sushiUpPos = PlayerPrefs.GetInt (SushiPosC,0);
//				_sushiUpPos = PlayerPrefs.GetInt (SushiPosD,0);
//				_sushiUpPos = PlayerPrefs.GetInt (SushiPosE,0);
//				_sushiUpPos = PlayerPrefs.GetInt (SushiPosF,0);
//			}
		}
	}
}
