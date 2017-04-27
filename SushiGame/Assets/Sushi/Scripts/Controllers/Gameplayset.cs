using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.GameManager;

namespace Scripts{
	namespace Controllers{
		public class Gameplayset : MonoBehaviour {

			public GameObject SushiSet1;
			public GameObject SushiSet2;

			CustomersManager _cmA;
			CustomersManagerB _cmB;

			// Use this for initialization
			void Start () {

				_cmA = GetComponent<CustomersManager> ();
				_cmB = GetComponent<CustomersManagerB> ();

				if (MainHomeManager.SetSelect == 1) {
					SushiSet1.SetActive (true);
					SushiSet2.SetActive (false);
					_cmA.enabled = true;
					_cmB.enabled = false;
				} else if(MainHomeManager.SetSelect == 2){
					SushiSet2.SetActive (true);
					SushiSet1.SetActive (false);
					_cmB.enabled = true;
					_cmA.enabled = false;
				}
			}
			
			// Update is called once per frame
			void Update () {

			}

			public void uiSushiset(){
				if(MainHomeManager.SetSelect == 1){
					SushiSet1.SetActive (false);
				}else if(MainHomeManager.SetSelect == 2){
					SushiSet2.SetActive (false);
				}
			}

			public void uiSushiNo(){
				if(MainHomeManager.SetSelect == 1){
					SushiSet1.SetActive (true);
				}else if(MainHomeManager.SetSelect == 2){
					SushiSet2.SetActive (true);
				}
			}
		}
	}
}