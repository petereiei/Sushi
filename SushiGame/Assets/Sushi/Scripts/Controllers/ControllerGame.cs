using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Scripts.GameManager;


namespace Scripts{
	namespace Controllers{
		public class ControllerGame : MonoBehaviour {

			public Image IconSushi;
			public List<Sprite> myIcon = new List<Sprite> ();
			public int _iconcount = 0;
			public GameObject[] _UiSushiSlot;
			public GameObject UiSlot;
			public GameObject IconUiSushi;

			public GameObject CustomersController;

			CustomersManager _CM;
			CustomersManagerB _CMB;

			// Use this for initialization
			void Start () {
				CustomersController = GameObject.Find ("CustomersManager");
				_CM = CustomersController.GetComponent<CustomersManager> ();
				_CMB = CustomersController.GetComponent<CustomersManagerB> ();
				IconUiSushi.SetActive (true);
				IconSushi.sprite = myIcon[0];
			}
			
			// Update is called once per frame
			void Update () {
				
			}

			public void OkSushi(){
				if(_iconcount == 0){
					SlotSushiA ();
					SushiConUI ();
				}
				else if(_iconcount == 1){
					SlotSushiB ();
					SushiConUI ();
				}
			}

			public void RightSelection(){
				if(_iconcount < myIcon.Count-1){
					_iconcount++;
					IconSushi.sprite = myIcon[_iconcount];
				}
			}

			public void LeftSelection(){
				if(_iconcount > 0){
					_iconcount--;
					IconSushi.sprite = myIcon[_iconcount];
				}
			}

			void SlotSushiA(){
				_UiSushiSlot[0].SetActive (true);
				_CM.enabled = true;
			}

			void SlotSushiB(){
				_UiSushiSlot[1].SetActive (true);
				_CMB.enabled = true;
			}

			void SushiConUI(){
				IconUiSushi.SetActive (false);
			}
		}
	}
}