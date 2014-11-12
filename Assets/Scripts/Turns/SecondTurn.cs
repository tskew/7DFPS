using UnityEngine;
using System.Collections;

public class SecondTurn : Turn{
	public override Turn GetNextTurn(string Id){
		return new FirstTurn();
	}
	
	public override Vector3 PlayerPosition() {
		return new Vector3 (-2.111747f, 0f, -8.101445f);
	}
}
