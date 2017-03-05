using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States { 
		cell,
		mirror,
		sheets_0,
		lock_0,
		sheets_1,
		cell_mirror,
		lock_1,
		corridor_0,
		stairs_0,
		floor,
		closet_door,
		corridor_1,
		stairs_1,
		in_closet,
		corridor_2,
		stairs_2,
		corridor_3,
		courtyard
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if 		(myState == States.cell)		state_cell ();
		else if (myState == States.sheets_0)	state_sheets_0 ();
		else if (myState == States.mirror)		state_mirror ();
		else if (myState == States.lock_0)		state_lock_0 ();
		else if (myState == States.sheets_1)	state_sheets_1 ();
		else if (myState == States.cell_mirror)	state_cell_mirror ();
		else if (myState == States.lock_1)		state_lock_1 ();
		else if (myState == States.corridor_0)	state_corridor_0 ();
		else if (myState == States.stairs_0)	state_stairs_0 ();
		else if (myState == States.floor)		state_floor ();
		else if (myState == States.closet_door) state_closet_door ();
		else if (myState == States.corridor_1)	state_corridor_1 ();
		else if (myState == States.stairs_1)	state_stairs_1 ();
		else if (myState == States.in_closet)	state_in_closet ();
		else if (myState == States.corridor_2)	state_corridor_2 ();
		else if (myState == States.stairs_2)	state_stairs_2 ();
		else if (myState == States.corridor_3)	state_corridor_3 ();
		else if (myState == States.courtyard)	state_courtyard ();
}

	void state_cell () {
		text.text = "You slowly open your eyes, while your head hurts like you had downed " +
					"multiple bottles of whiskey. You take an inventory of your state, " +
					"and while your head is sensitive to touch, otherwise you seem to be okay. " +
					"At the same time you start to inspect your surroundings...\n" +
					"You're in a locked room, with only some dirty sheets on the bed, " +
					"a mirror on the wall and the door, which you notice is locked from the " +
					"outside...\n\n" +
					"Press S to view the sheets, M to view the mirror or L to view the lock";
		if 		(Input.GetKeyDown (KeyCode.S)) myState = States.sheets_0;
		else if (Input.GetKeyDown (KeyCode.M)) myState = States.mirror;
		else if (Input.GetKeyDown (KeyCode.L)) myState = States.lock_0;
	}

	void state_mirror () {
		text.text = "You notice a wire hanging from behind the mirror. It could be used to pick the lock...\n\n" +
					"Press T to take the wire or R to return";
		if 		(Input.GetKeyDown (KeyCode.T)) myState = States.cell_mirror;
		else if (Input.GetKeyDown (KeyCode.R)) myState = States.cell;
	}

	void state_sheets_0 () {
		text.text = "The sheets are dirty and crawling with lice. You feel itchy...\n\n" +
					"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) myState = States.cell;
	}

	void state_lock_0 () {
		text.text = "The door is locked and you don't see anything that you can do with it...\n\n" +
					"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) myState = States.cell;
	}

	void state_sheets_1 () {
		text.text = "Nothing has changed here...\n\n" +
					"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) myState = States.cell_mirror;
	}

	void state_cell_mirror () {
		text.text = "You now have everything you need to escape...\n\n" +
					"Press S to view the sheets or L to view the lock";
		if 		(Input.GetKeyDown (KeyCode.S)) myState = States.sheets_1;
		else if (Input.GetKeyDown (KeyCode.L)) myState = States.lock_1;
	}

	void state_lock_1 () {
		text.text = "You might be able to pry the door open with the wire now...\n\n" +
					"Press O to open the lock or R to return";
		if 		(Input.GetKeyDown (KeyCode.O)) myState = States.corridor_0;
		else if (Input.GetKeyDown (KeyCode.R)) myState = States.cell_mirror;
	}

	void state_corridor_0 () {
		text.text = "You're in an empty corridor. You can see a staircase and a closet door...\n\n" +
					"Press S to inspect the stairs, C to inspect the closet or F to inspect something " +
					"glimmering on the floor";
		if 		(Input.GetKeyDown (KeyCode.S)) myState = States.stairs_0;
		else if (Input.GetKeyDown (KeyCode.C)) myState = States.closet_door;
		else if (Input.GetKeyDown (KeyCode.F)) myState = States.floor;
	}

	void state_stairs_0 () {
		text.text = "The staircase looks very ominous and you can hear noise from there...\n\n" +
					"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) myState = States.corridor_0;
	}

	void state_floor () {
		text.text = "The glimmer you noticed was a hairclip! Maybe you could use it as a lockpick...\n\n" +
					"Press R to return or H to take the hairclip";
		if 		(Input.GetKeyDown (KeyCode.R)) myState = States.corridor_0;
		else if (Input.GetKeyDown (KeyCode.H)) myState = States.corridor_1;
	}

	void state_closet_door () {
		text.text = "The closet's door is locked and you're afraid too much noise might alert whoever is " +
					"down the staircase...\n\n" +
					"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) myState = States.corridor_0;
	}

	void state_stairs_1 () {
		text.text = "You still don't dare trying to sneak past whoever is down there...\n\n" +
					"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) myState = States.corridor_1;
	}

	void state_corridor_1 () {
		text.text = "With the hairclip on hand, you might try to pick the closet door...\n\n" +
					"Press S to inspect the stairs or P to pick open the closet door";
		if 		(Input.GetKeyDown (KeyCode.S)) myState = States.stairs_1;
		else if (Input.GetKeyDown (KeyCode.P)) myState = States.in_closet;
	}

	void state_in_closet () {
		text.text = "There are some cleaning tools and a cleaner's uniform in the closet.\n\n" +
					"You might want to try it on as a disguise...\n\n" +
					"Press R to return to the corridor or D to put on the uniform";
		if		(Input.GetKeyDown (KeyCode.R)) myState = States.corridor_2;
		else if (Input.GetKeyDown (KeyCode.D)) myState = States.corridor_3;
	}

	void state_corridor_2 () {
		text.text = "You might want to try that cleaner's uniform...\n\n" +
					"Press B to go back to the closet or S to view the stairs";
		if		(Input.GetKeyDown (KeyCode.B)) myState = States.in_closet;
		else if (Input.GetKeyDown (KeyCode.S)) myState = States.stairs_2;
	}

	void state_stairs_2 () {
		text.text = "The sound is getting louder!\n\n" +
					"Press R to return";
		if (Input.GetKeyDown (KeyCode.R)) myState = States.corridor_2;
	}

	void state_corridor_3 () {
		text.text = "Looking as a cleaner, you might try to sneak past whoever is down there...\n\n" +
					"Press U to undress or S to go down the stairs";
		if		(Input.GetKeyDown (KeyCode.U)) myState = States.in_closet;
		else if (Input.GetKeyDown (KeyCode.S)) myState = States.courtyard;
	}

	void state_courtyard () {
		text.text = "As usual no one notices the cleaners. You find yourself in a courtyard and realise " +
					" that you are free!\n\n" +
					"Press P to play again";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		}
	}
}
