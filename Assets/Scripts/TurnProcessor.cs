using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class TurnProcessor : MonoBehaviour {
	private Turn previousTurn;
	private Turn currentTurn;
	private float speed = 3;

	void Start() {
		currentTurn = new FirstTurn ();
		previousTurn = new FirstTurn ();
	}

	void Update() {
		MoveUnit (this.gameObject, currentTurn.PlayerPosition (), previousTurn.PlayerPosition ());

		foreach (TurnActivity mobActivity in currentTurn.MobActivities()) {
			TurnActivity previousActivity = previousTurn.MobActivities().Where(prev => prev.tag == mobActivity.tag).SingleOrDefault();
			if (previousActivity == null) {previousActivity = mobActivity;};
			MoveUnit(GameObject.FindGameObjectWithTag(mobActivity.tag), mobActivity.position, previousActivity.position);	
		}
	}

	void MoveUnit(GameObject unit, Vector3 plannedPosition, Vector3 previousPosition) {
		if (Vector3.Distance (unit.transform.position, plannedPosition) > .1f) { 
			Vector3 directionOfTravel = plannedPosition - previousPosition;
			//now normalize the direction, since we only want the direction information
			directionOfTravel.Normalize ();
			//scale the movement on each axis by the directionOfTravel vector components
			
			unit.transform.Translate (
				(directionOfTravel.x * speed * Time.deltaTime),
				(directionOfTravel.y * speed * Time.deltaTime),
				(directionOfTravel.z * speed * Time.deltaTime),
				Space.World);
		}
	}
		
	public void RunTurn(string Id) {
		Turn nextTurn = currentTurn.GetNextTurn (Id);
		previousTurn = currentTurn;
		currentTurn = nextTurn;
	}
}
