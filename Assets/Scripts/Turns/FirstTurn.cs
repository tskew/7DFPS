using UnityEngine;
using System.Collections;
using System;

public class FirstTurn : Turn {
	public override Turn GetNextTurn(string Id){
		if (Id == "left") {
			return new leftSecondTurn();
		} else if (Id == "middle") {
			return new middleSecondTurn();
		} else if (Id == "right") {
			return new rightSecondTurn();
		} else {
			return new FirstTurn();
		}
	}

	public override Vector3 PlayerPosition() {
		return new Vector3 (-5.118403f, 0f, -8.101445f);
	}
}
