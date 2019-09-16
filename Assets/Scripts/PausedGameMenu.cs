using UnityEngine.SceneManagement;
using UnityEngine;

public class PausedGameMenu : MonoBehaviour {

	public void ResumeClicked()
	{
		Time.timeScale = 1;
		gameObject.SetActive(false);
	}

	public void MenuClicked()
	{
		gameObject.SetActive(false);
		SceneManager.LoadScene(0);
	}
}
