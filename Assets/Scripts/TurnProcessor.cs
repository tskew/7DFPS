﻿using UnityEngine;
using System.Collections;

public class TurnProcessor : MonoBehaviour {
	private Turn previousTurn;
	private Turn currentTurn;
	private float speed = 3;

	void Start() {
		currentTurn = new FirstTurn ();
		previousTurn = new FirstTurn ();
	}

	void Update() {
		if (Vector3.Distance (this.transform.position, currentTurn.PlayerPosition ()) > .1f) { 
			Vector3 directionOfTravel = currentTurn.PlayerPosition () - previousTurn.PlayerPosition ();
			//now normalize the direction, since we only want the direction information
			directionOfTravel.Normalize ();
			//scale the movement on each axis by the directionOfTravel vector components

			this.transform.Translate (
				(directionOfTravel.x * speed * Time.deltaTime),
				(directionOfTravel.y * speed * Time.deltaTime),
				(directionOfTravel.z * speed * Time.deltaTime),
				Space.World);
		}
	}
		
	public void RunTurn(string Id) {
		Turn nextTurn = currentTurn.GetNextTurn (Id);
		previousTurn = currentTurn;
		currentTurn = nextTurn;
	}
}
