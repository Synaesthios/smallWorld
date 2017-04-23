using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public void OnPointerEnter(PointerEventData eventData) {
		//Debug.Log("OnPointerEnter");
		if(eventData.pointerDrag == null)
			return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null) {
			d.placeholderParent = this.transform;
		}
	}
	
	public void OnPointerExit(PointerEventData eventData) {
		//Debug.Log("OnPointerExit");
		if(eventData.pointerDrag == null)
			return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null && d.placeholderParent==this.transform) {
			d.placeholderParent = d.parentToReturnTo;
		}
	}
	
	public void OnDrop(PointerEventData eventData) {
		Debug.Log ("Dropping " + eventData.pointerDrag.name);

		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null){
			if (this.name == "Tabletop" && this.transform.childCount > 0) {
				Debug.Log ("There is already a card on " + gameObject.name);
				d.placeholderParent = d.parentToReturnTo;
			}
			else {
				Debug.Log (eventData.pointerDrag.name + " was dropped on " + gameObject.name);
				d.parentToReturnTo = this.transform;
			}
		}
	}
}
