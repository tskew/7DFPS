using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {
	public RaycastHit hit;

	private Targeted lastTarget;
	private Targeted currentTarget;

	void Update () {
		if (Input.GetMouseButtonDown(0)){
			OnMouseDown();
		}
	}

	void OnMouseDown () {
		if (currentTarget != null) {
			lastTarget = currentTarget;
			currentTarget.currentlyTargetted = false;
		}

		Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));

		if (Physics.Raycast(ray, out hit, 100)){
			currentTarget = hit.collider.gameObject.GetComponent<Targeted>();
			if (currentTarget != null) {
				if (lastTarget == currentTarget) {
					TurnProcessor turnProcessor = this.gameObject.GetComponent<TurnProcessor>();
					turnProcessor.RunTurn(currentTarget.Id);
				} else {
					currentTarget.currentlyTargetted = true;
				}
			}
		}	
	}
}
