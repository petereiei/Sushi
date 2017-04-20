using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Controllers.Customers{
	public class SpawnCustomers : MonoBehaviour {

		public GameObject[] Customers;
		public Transform[] CMpoints;
		private GameObject cm;
		public List<GameObject> CmPos;
		public bool SushislotA = true;
		public bool SushislotB = true;
		public bool SushislotC = true;
		public bool SushislotD = true;
		public bool SushislotE = true;
		//private int customers;
		public int CMcount = 0;

		// Use this for initialization
		void Start () {
			CmPos = new List<GameObject> ();
			InvokeRepeating ("spwanCM",2,2);

		}

		// Update is called once per frame
		void Update(){
		}

		public void spwanCM(){
			if (SushislotA == true) {
				SpwanPointA ();
			}
			if(SushislotB == true){
				SpwanPointB ();
			}
		}

		public void ReCustomersCount(){
			Debug.Log ("ReCustomersCount");
			CmPos.Remove (cm.gameObject);
			Debug.Log ("Destroy.cm");
			if(SushislotA == false){
				SushislotA = true;
				CMcount--;
			}
			else if(SushislotB == false){
				SushislotB = true;
				CMcount--;
			}
		}

		public void SpwanPointA(){
			if(SushislotA == true && CMcount <= 5){
			//if(CMcount < CMpoints.Length && CMcount <= 5){
			//	customers = Random.Range (0, Customers.Length);
				cm = Instantiate (Customers[0],CMpoints[0].transform.position,Quaternion.identity);
			SushislotA = false;

				Debug.LogWarning (cm.gameObject.name);

			CmPos.Add (cm.gameObject);
				//cm.name = Customers[customers].name;
				Debug.Log (CMpoints[0].name+ " Spawn " + cm.name);
				CMcount++;
			}
		}

		public void SpwanPointB(){
			if(SushislotB == true && CMcount <= 5){
			//if(CMcount < CMpoints.Length && CMcount <= 5){
			//	customers = Random.Range (0, Customers.Length);
				cm = Instantiate (Customers[1],CMpoints[1].transform.position,Quaternion.identity);
			SushislotB = false;	
			CmPos.Add (cm.gameObject);
				//cm.name = Customers[customers].name;
				//cm.transform.position = CMpoints[1].position;
				Debug.Log (CMpoints[1].name+ " Spawn " + cm.name);
				CMcount++;
			}
		}

//		public void SpwanPointC(){
//			//if(CMcount < CMpoints.Length && CMcount <= 5){
//				//customers = Random.Range (0, Customers.Length);
//				GameObject cm = Instantiate (Customers[customers],CMpoints[2].transform.position,Quaternion.identity);
//				//CmPos.Add (cm.gameObject);
//				//cm.name = Customers[customers].name;
//				Debug.Log (CMpoints[CMcount].name+ " Spawn " + cm.name);
//				CMcount++;
//			//}
//		}
//
//		public void SpwanPointD(){
//			//if(CMcount < CMpoints.Length && CMcount <= 5){
//				//customers = Random.Range (0, Customers.Length);
//				GameObject cm = Instantiate (Customers[customers],CMpoints[3].transform.position,Quaternion.identity);
//				//CmPos.Add (cm.gameObject);
//				//cm.name = Customers[customers].name;
//				Debug.Log (CMpoints[CMcount].name+ " Spawn " + cm.name);
//				CMcount++;
//			//}
//		}
//
//		public void SpwanPointE(){
//			//if(CMcount < CMpoints.Length && CMcount <= 5){
//				//customers = Random.Range (0, Customers.Length);
//				GameObject cm = Instantiate (Customers[customers],CMpoints[4].transform.position,Quaternion.identity);
//				//CmPos.Add (cm.gameObject);
//				//cm.name = Customers[customers].name;
//				Debug.Log (CMpoints[CMcount].name+ " Spawn " + cm.name);
//				CMcount++;
//			//}
//		}
	}
}