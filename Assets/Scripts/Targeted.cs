using UnityEngine;
using System.Collections;

public class Targeted : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTarget() {
		Debug.Log ("Targetted");
		renderer.material.SetColor ("_OutlineColor", Color.red);
	}
}
