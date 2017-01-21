using UnityEngine;
using System.Collections;

public class BattleStates : MonoBehaviour {

	public cannoncontroller player;
	public enemy thebadGuyz;
	// Use this for initialization
	public enum BattleState
	{
		start,
		PlayersTurn,
		EnemiesTurn,
		Win,
		Win2,
		Loose,
		hold
	}

	public BattleState currentState;
	void Start () {
		currentState = BattleState.PlayersTurn;
	}
	
	// Update is called once per frame
	void Update () {

		switch (currentState) {
		case (BattleState.PlayersTurn):
			player.load_the_cannons_matey();
			break;

		case (BattleState.EnemiesTurn):
			
			thebadGuyz.myTurnBuddy ();
			currentState = BattleState.hold;
			break;

		case (BattleState.start):
			player.load_the_cannons_matey();
			break;

		case (BattleState.Win):
			Application.LoadLevel("level2");//set isLoaded to true
			break;
		case (BattleState.Win2):
			Application.LoadLevel("winningscreen");//set isLoaded to true
			break;
		case (BattleState.Loose):
			//set isLoaded to true
			Application.LoadLevel("mainmenu");
			break;
		case (BattleState.hold):
			//set isLoaded to true
			break;
		}
	
	}
	public void itsPlayersTurn()
	{
		
		currentState = BattleState.PlayersTurn;
	}
	public void itsCompsTurn()
	{

		currentState = BattleState.EnemiesTurn;
	}
	public void playerLost ()
	{
		currentState = BattleState.Loose;
	}
	public void playerwon()
	{
		currentState = BattleState.Win;
	}
	public void playerwon2()
	{
		currentState = BattleState.Win2;
	}
}
