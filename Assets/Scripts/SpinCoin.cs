using UnityEngine;

public class SpinCoin : MonoBehaviour {

	// public GameObject coinObject;
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3 (0f ,-350f, 0f)*Time.deltaTime);
	}

	// void OnTriggerEnter(Collider other) {
	// 	if (other.CompareTag("Player"))
	// 	{
	// 		// coinObject.gameObject.SetActive(false);
	// 		// coinObject.SetActive(false);
	// 		Destroy(gameObject);
	// 		// Debug.Log("collided with player!");
	// 	}
    //     // Destroy(other.gameObject);
    // }


}
