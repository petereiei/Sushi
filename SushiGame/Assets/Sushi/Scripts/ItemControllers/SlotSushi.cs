using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Scripts{
	namespace ItemControllers{
		public class SlotSushi : MonoBehaviour, IDropHandler {


			public GameObject item{
				get{
					if (transform.childCount > 0) {
						return transform.GetChild (0).gameObject;

					} else {
						return null;
					}
				}
		}

			#region IDropHandler implementation

			public void OnDrop (PointerEventData eventData)
			{
				if(!item){
					DragItem.ItemSushi.transform.SetParent (transform);
				}
			}

			#endregion
		}
	}
}
