using UnityEngine;

public class KeepPlaying : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(transform.gameObject);
	}
}
