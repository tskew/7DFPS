﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Turn {
	public abstract Turn GetNextTurn(string Id);
	public abstract Vector3 PlayerPosition ();
	public abstract Dictionary<string, Vector3> MobPositions();
	public abstract IEnumerable<string> ActiveMobs();
}
