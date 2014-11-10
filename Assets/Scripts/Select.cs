using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {
	public RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			OnMouseDown();
		}
	}

	void OnMouseDown () {
		Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));
		Debug.Log ("Fired ray");

		if (Physics.Raycast(ray, out hit, 100)){
			Debug.Log("Hit object");
			hit.collider.gameObject.GetComponent<Targeted>().OnTarget();
		}	}
}
