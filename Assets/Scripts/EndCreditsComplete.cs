using UnityEngine.SceneManagement;
using UnityEngine;

public class EndCreditsComplete : MonoBehaviour {

	public void GoToMenu()
	{
		//returns me to main menu once credits are done rolling.
		SceneManager.LoadScene(0);
	}
}
