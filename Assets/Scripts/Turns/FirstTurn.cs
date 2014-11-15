using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

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

	public override IEnumerable<TurnActivity> MobActivities ()
	{
		return new List<TurnActivity> (){
			new TurnActivity("right", new Vector3(-2.191365f, 0f, -1.87339f)),
			new TurnActivity("left", new Vector3(-8.017928f, 0f, -1.722533f))
		};
	}
}
