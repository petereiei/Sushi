using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


namespace Scripts{
	namespace Controllers{
		public class Controller : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler {

			public void OnBeginDrag(PointerEventData eventData){
				Debug.Log ("OnBeginDrag");
				//this.transform.SetParent (this.transform.parent.parent);
			}

			public void OnDrag(PointerEventData eventData){
				Debug.Log ("OnDrag");
				this.transform.position = eventData.position;
			}

			public void OnEndDrag(PointerEventData eventData){
				Debug.Log ("OnEndDrag");
				Destroy (gameObject);
			}
		}
	}
}
