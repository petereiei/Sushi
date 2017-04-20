using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.GameManager;

namespace Scripts.Controllers.Customers{
	public class Customers : MonoBehaviour {

//		public GameObject[] CustomersObj;
//		public Transform[] PosCustomer;
//
//		private GameObject cm;
//		private int Counts = 1;
//
//		// Use this for initialization
//		void Start () {
//		}
//		
//		// Update is called once per frame
//		void Update () {
//			if(CustomersManager.CountCustomer <= 4){
//				SpawnCustomer ();
//			}
//		}
//
//		void SpawnCustomer(){
//			CustomersManager.idCustomer = Random.Range (0, CustomersObj.Length);
//			CustomersManager.idPosCustomer = Random.Range (0, PosCustomer.Length);
//			cm = Instantiate (CustomersObj[CustomersManager.idCustomer], PosCustomer[CustomersManager.idPosCustomer].transform.position,Quaternion.identity);
//			CustomersManager.CountCustomer += Counts;
//			cm.name = CustomersObj [CustomersManager.idCustomer].name;
//			Debug.Log (cm.name);
//			Debug.Log (" CustomerObj "+CustomersManager.idCustomer);
//			Debug.Log (" PosCustomer "+CustomersManager.idPosCustomer);
//			Debug.Log (CustomersManager.CountCustomer);
//
//		}
	}
}