using System;

public class middleSecondTurn: Turn
{
	public override Turn GetNextTurn (string Id)
	{
		return new FirstTurn ();
	}

	public override UnityEngine.Vector3 PlayerPosition ()
	{
		throw new NotImplementedException ();
	}
}


