using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnded = false;

	public float retryDelay = 1f;

	public GameObject levelPassedUI;

	public void LevelPassed()
	{
		levelPassedUI.SetActive(true);
		Debug.Log("Level Passed!");
	}
	public void GameEnd()// setting public allows me to access this function from any script
	{	
		if (!gameEnded)
		{
			gameEnded = true;
			Debug.Log("Game Over!");
			Invoke("Retry", retryDelay);
		}
		
	}

	//this function is called when the player is hit by the enemy    u know u dead!!
	void Retry()
	{
		
		if (PlayerPrefs.GetFloat("Difficulty") == 15)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		} else
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

}
