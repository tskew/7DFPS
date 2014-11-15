using System;
using UnityEngine;
using System.Collections.Generic;

public class rightSecondTurn: Turn
{
	public override Turn GetNextTurn (string Id)
	{
		return new FirstTurn ();
	}
	
	public override Vector3 PlayerPosition ()
	{
		return new Vector3 (-2.111747f, 0f, -8.101445f);
	}

	public override IEnumerable<TurnActivity> MobActivities ()
	{
		return new List<TurnActivity> (){
			new TurnActivity("right", new Vector3(-2.191364f, 0f, -5.68822f)), 
			new TurnActivity("left", new Vector3(-8.017927f, 0f, -5.856345f))
		};
	}
}
