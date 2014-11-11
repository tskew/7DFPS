using UnityEngine;
using System.Collections;

public class Targeted : MonoBehaviour {
	public bool currentlyTargetted;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (currentlyTargetted) {
			renderer.material.SetColor ("_OutlineColor", Color.red);
		} else {
			renderer.material.SetColor("_OutlineColor", Color.black);
		}
	}

	void OnGUI () {
		if (currentlyTargetted) {
			Vector3 screenPos = Camera.main.WorldToScreenPoint (transform.position);

			GUIContent content = new GUIContent("Current Target\nCombat State: Inactive\nThreat: None");
			GUI.Box( new Rect (screenPos.x + 50, Screen.height - screenPos.y - 275, 150, 55), content );
		}
	}
}
