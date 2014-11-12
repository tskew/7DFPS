using UnityEngine;
using System.Collections;
using System;

public class FirstTurn : Turn {
	public override Turn GetNextTurn(string Id){
		Debug.Log ("Returning next turn");
		return new SecondTurn();
	}

	public override Vector3 PlayerPosition() {
		return new Vector3 (-5.118403f, 0f, -8.101445f);
	}
}
