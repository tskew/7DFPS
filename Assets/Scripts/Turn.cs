using UnityEngine;
using System.Collections;

public abstract class Turn {
	public abstract Turn GetNextTurn(string Id);
	public abstract Vector3 PlayerPosition ();
}
