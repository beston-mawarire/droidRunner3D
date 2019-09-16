using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	//this sis where I want it to go
	public Transform[] target;

	public Rigidbody enemyBody;

	//this is the speed to move at
	public float enemySpeed;

	//this is where I am right now(which target)
	private int current;
	
	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		enemySpeed = PlayerPrefs.GetFloat("Difficulty", 45);
	}
	
	// Update is called once per frame
	void Update () {
		//move till you get to targeted position
		//if my position is not equals to the targeted location
		if(transform.position != target[current].position){
			Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, enemySpeed * Time.deltaTime); // Vector3.movetowards(player current position, targets current position, speed to move there at)
			enemyBody.MovePosition(pos);// MovePosition() accepts a vector3 as a parameter
		} else{
			//target reached, move to next target
			current = (current + 1) % target.Length;
		}
	}

	//This command runs whenever the player collides with any object in-game, including the floor
	//The second argument is the reference for the Collision argument
	void OnCollisionEnter(Collision whatIHit)
	{
		//by using whatIHit we can gather more information about the collider, what we are hitting and specify certain things
		//we can also put in conditions whn specific objects are hit
		if (whatIHit.collider.tag == "Player")
		{
			//stops all player movement
			GetComponent<EnemyMovement>().enabled = false;
			// whatIHit.collider.GetComponent("Transform" ,transform);
		}
	}
}
