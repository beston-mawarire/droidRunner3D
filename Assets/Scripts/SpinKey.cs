using UnityEngine;

public class SpinKey : MonoBehaviour {

	private int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
    private float movetop = 1f;
    private float movebottom = 0.5f;

    float movespeed = 0.5f;

	// Update is called once per frame
	void Update () {
		//make the key rotate on it's own,  y axis
		transform.Rotate(new Vector3 (0f ,130f, 0f)*Time.deltaTime);

		if (transform.position.y >= movetop)
            direction = -1;

        if (transform.position.y <= movebottom)
            direction = 1;

        transform.Translate(0, movespeed * direction * Time.deltaTime, 0);

		// if(transform.position != target[current].position){
		// 	// Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, keySpeed * Time.deltaTime); // Vector3.movetowards(player current position, targets current position, speed to move there at)
		// 	transform.Translate(translation: target[current].position*Time.deltaTime);// MovePosition() accepts a vector3 as a parameter
		// } else{
		// 	//target reached, move to next target
		// 	current = (current + 1) % target.Length;
		// }
	}

}
