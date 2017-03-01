using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Scripts{
	namespace ItemControllers{

		public class DragItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

			public static GameObject ItemSushi;
			Vector3 stratPosition;
			Transform stratParent;

			#region IBeginDragHandler implementation

			public void OnBeginDrag (PointerEventData eventData)
			{
				ItemSushi = gameObject;
				stratPosition = transform.position;
				stratParent = transform.parent;

				GetComponent<CanvasGroup> ().blocksRaycasts = false;
			}

			#endregion

			#region IDragHandler implementation

			public void OnDrag (PointerEventData eventData)
			{
				transform.position = Input.mousePosition;
			}

			#endregion

			#region IEndDragHandler implementation

			public void OnEndDrag (PointerEventData eventData)
			{
				ItemSushi = null;
				GetComponent<CanvasGroup> ().blocksRaycasts = true;

				if(transform.parent == stratParent){

					transform.position = stratPosition;
				}
				//GetComponent<CanvasGroup> ().blocksRaycasts = true;
				//GetComponentInParent<GridLayoutGroup> ().enabled = true;
			}

			#endregion
		}
	}
}
