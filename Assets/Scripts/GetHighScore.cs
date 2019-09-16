using UnityEngine;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour {
	// public Text highScoreText;
	// Use this for initialization
	// private Text txt;
	public Text highscoreText;

	void Start () {
		highscoreText.text = PlayerPrefs.GetInt("HighScore",0).ToString();
		Debug.Log("text is: " + highscoreText.text);
		// Text highScore = gameObject.GetComponent<Text>();
		// highScoreText.text = "dfgh"; //PlayerPrefs.GetInt("HighScore", 0).ToString();

	}

	public void ResetClicked()
	{
		//deleting high score and updating the text
		PlayerPrefs.DeleteKey("HighScore");
		highscoreText.text = PlayerPrefs.GetInt("HighScore",0).ToString();
	}
}
