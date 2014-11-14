using System;
using System.Collections.Generic;
using UnityEngine;

public class middleSecondTurn: Turn
{
	public override Turn GetNextTurn (string Id)
	{
		return new FirstTurn ();
	}

	public override Vector3 PlayerPosition ()
	{
		throw new NotImplementedException ();
	}

	public override Dictionary<string, Vector3> MobPositions ()
	{
		return new Dictionary<string, Vector3> ();
	}

	public override IEnumerable<string> ActiveMobs ()
	{
		return new List<string>();
	}
}


