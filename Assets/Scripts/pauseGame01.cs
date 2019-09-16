using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseGame01 : MonoBehaviour {
	public GameObject pauseGameUI;
	bool gameCurrentlyPaused;
	// Use this for initialization
	void Start () {
		gameCurrentlyPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("escape"))
		{
			gameCurrentlyPaused = !gameCurrentlyPaused;
			if(gameCurrentlyPaused)
			{
				Time.timeScale = 0;
				pauseGameUI.SetActive(true);
				Debug.Log("It's supposed to pause!");
			} else
			{
				Time.timeScale = 1;
				pauseGameUI.SetActive(false);
				Debug.Log("It's supposed to resume!");
			}
		}
	}

	public void ResumeClicked()
	{	
		gameCurrentlyPaused = !gameCurrentlyPaused;
		if(!gameCurrentlyPaused)
		{
			Time.timeScale = 1;
			pauseGameUI.SetActive(false);
			Debug.Log("It's supposed to resume!");
		}
		
	}

	public void MainMenuButtonClicked()
	{
		Time.timeScale = 1;
		pauseGameUI.SetActive(false);
		PlayerPrefs.DeleteKey("Points");
		if(PlayerPrefs.GetInt("Points", 0) > PlayerPrefs.GetInt("HighScore", 0)){
			PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Points", 0));
		};
		SceneManager.LoadScene(0);
	}
}
