using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour {

	public  GameObject barrier;

	public Text scoreText;

	private int pointCount;
	public AudioSource coinSound;

	public AudioSource keySound;


	//reference to UI text game object
	public Rigidbody playerBody;

	public float speed;


	void Start()
	{
		speed = 10f;
		pointCount = PlayerPrefs.GetInt("Points",0);
		SetScoreText ();
		// coinSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,speed*Input.GetAxis("Vertical")*Time.deltaTime);	
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Pickup"))
		{
			pointCount += 1;
			SetScoreText ();
			coinSound.Play();
			Destroy(other.gameObject);
		}
		if (other.tag == "Key pickup")
		{
			keySound.Play();
			barrier.SetActive(false);
			Destroy(other.gameObject);
		}
        // Destroy(other.gameObject);
    }

	void SetScoreText ()
	{
		PlayerPrefs.SetInt("Points", pointCount);
		scoreText.text = "Points: "	+ pointCount.ToString();
	}
}
//clint... close to me
