using System;
using UnityEngine;

public class rightSecondTurn: Turn
{
	public override Turn GetNextTurn (string Id)
	{
		return new FirstTurn ();
	}
	
	public override UnityEngine.Vector3 PlayerPosition ()
	{
		return new Vector3 (-2.111747f, 0f, -8.101445f);
	}
}
