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
				}if(PlayerStatus.Table2On == false){
					Table2.SetActive (false);
				}if(PlayerStatus.Table3On == false){
					Table3.SetActive (false);
				}if(PlayerStatus.Table4On == false){
					Table4.SetActive (false);
				}if(PlayerStatus.Table5On == false){
					Table5.SetActive (false);
				}if(PlayerStatus.Table6On == false){
					Table6.SetActive (false);
				}if(PlayerStatus.Table7On == false){
					Table7.SetActive (false);
				}if(PlayerStatus.Table8On == false){
					Table8.SetActive (false);
				}


				if(PlayerStatus.Table1On == true){
					Table1.SetActive (true);
				}if(PlayerStatus.Table2On == true){
					Table2.SetActive (true);
				}if(PlayerStatus.Table3On == true){
					Table3.SetActive (true);
				}if(PlayerStatus.Table4On == true){
					Table4.SetActive (true);
				}if(PlayerStatus.Table5On == true){
					Table5.SetActive (true);
				}if(PlayerStatus.Table6On == true){
					Table6.SetActive (true);
				}if(PlayerStatus.Table7On == true){
					Table7.SetActive (true);
				}if(PlayerStatus.Table8On == true){
					Table8.SetActive (true);
				}
				
			}
		}
	}
}
