using UnityEngine;

public class PlayerCollided : MonoBehaviour {

	//reference to the Player Behaviour component in unity
	public MovePlayer movement;

	public AudioSource hitSound;

	//This command runs whenever the player collides with any object in-game, including the floor
	//The second argument is the reference for the Collision argument
	void OnCollisionEnter(Collision whatIHit)
	{
		//by using whatIHit we can gather more information about the collider, what we are hitting and specify certain things
		//we can also put in conditions whn specific objects are hit
		if (whatIHit.collider.tag == "Enemy")
		{
			//stops all player movement
			hitSound.Play();
			movement.enabled = false;
			// whatIHit.collider.GetComponent("Transform" ,transform);
			if(PlayerPrefs.GetInt("Points", 0) > PlayerPrefs.GetInt("HighScore", 0)){
				PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Points", 0));
			};
			PlayerPrefs.DeleteKey("Points");
			FindObjectOfType<GameManager>().GameEnd();
		}
		if (whatIHit.collider.tag == "LevelDoor")
		{
			//stops all player movement
			Debug.Log("I hit the Door!");
		}
	}
}