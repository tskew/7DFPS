using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class NullTurn : Turn {
	public override Turn GetNextTurn(string Id){
		return new NullTurn ();
	}
	
	public override Vector3 PlayerPosition() {
		return new Vector3 ();
	}
	
	public override IEnumerable<TurnActivity> MobActivities ()
	{
		return new List<TurnActivity> ();
	}
}


