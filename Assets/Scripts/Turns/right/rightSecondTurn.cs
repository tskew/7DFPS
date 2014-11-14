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

	public override Dictionary<string, Vector3> MobPositions ()
	{
		return new Dictionary<string, Vector3> (){{"right", new Vector3(-2.191364f, 0f, -5.68822f)}, {"left", new Vector3(-8.017927f, 0f, -5.856345f)}};
	}

	public override IEnumerable<string> ActiveMobs ()
	{
		return new List<string>(){"right", "left"};
	}
}
