using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts{
	namespace Controllers{
		public class TableController : MonoBehaviour {

			public GameObject Table1;
			public GameObject Table2;
			public GameObject Table3;
			public GameObject Table4;
			public GameObject Table5;
			public GameObject Table6;
			public GameObject Table7;
			public GameObject Table8;

			// Use this for initialization
			void Start () {

				if(TablePopUpUI.TableNumber == 1){
					Table1.SetActive (true);
					Debug.Log (TablePopUpUI.TableNumber);
				}if(TablePopUpUI.TableNumber == 2){
					Table1.SetActive (true);
					Table2.SetActive (true);
					Debug.Log (TablePopUpUI.TableNumber);
				}if(TablePopUpUI.TableNumber == 3){
					Table1.SetActive (true);
					Table2.SetActive (true);
					Table3.SetActive (true);
					Debug.Log (TablePopUpUI.TableNumber);
				}if(TablePopUpUI.TableNumber == 4){
					Table1.SetActive (true);
					Table2.SetActive (true);
					Table3.SetActive (true);
					Table4.SetActive (true);
					Debug.Log (TablePopUpUI.TableNumber);
				}if(TablePopUpUI.TableNumber == 5){
					Table1.SetActive (true);
					Table2.SetActive (true);
					Table3.SetActive (true);
					Table4.SetActive (true);
					Table5.SetActive (true);
				}if(TablePopUpUI.TableNumber == 6){
					Table1.SetActive (true);
					Table2.SetActive (true);
					Table3.SetActive (true);
					Table4.SetActive (true);
					Table5.SetActive (true);
					Table6.SetActive (true);
				}if(TablePopUpUI.TableNumber == 7){
					Table1.SetActive (true);
					Table2.SetActive (true);
					Table3.SetActive (true);
					Table4.SetActive (true);
					Table5.SetActive (true);
					Table6.SetActive (true);
					Table7.SetActive (true);
				}if(TablePopUpUI.TableNumber == 8){
					Table1.SetActive (true);
					Table2.SetActive (true);
					Table3.SetActive (true);
					Table4.SetActive (true);
					Table5.SetActive (true);
					Table6.SetActive (true);
					Table7.SetActive (true);
					Table8.SetActive (true);
				}
				
			}
			
			// Update is called once per frame
			void Update () {
				if(PlayerStatus.Table1On == false){
					Table1.SetActive (false);
				}
				
			}
		}
	}
}
