using System;
using System.Collections.Generic;
using UnityEngine;

public class leftSecondTurn: Turn
{
	public override Turn GetNextTurn (string Id)
	{
		return new FirstTurn ();
	}

	public override Vector3 PlayerPosition ()
	{
		throw new NotImplementedException ();
	}

	public override IEnumerable<TurnActivity> MobActivities ()
	{
		return new List<TurnActivity> ();
	}
}


