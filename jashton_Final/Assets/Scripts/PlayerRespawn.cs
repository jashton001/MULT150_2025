using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager; 

	// Triggers when the player enters the water
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			// Moves the player to the spawn point
			gameManager.PositionPlayer();
			Debug.Log("Player hit the hazard! Respawning...");
		}
	}
}
