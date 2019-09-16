using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public void PlayClicked()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitClicked()
	{
		Debug.Log("Quit game!");
		Application.Quit();
	}
}
