using UnityEngine;
using UnityEngine.UI;

public class SetDifficulty : MonoBehaviour {

	public Text difficultyText;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		float currentDifficulty = PlayerPrefs.GetFloat("Difficulty", 30f);
		//for future, use switch statement.
		if (currentDifficulty == 15f)
		{
			difficultyText.text = "Easy : Please hold my hand.";
		}
		if (currentDifficulty == 30f)
		{
			difficultyText.text = "Normal : I can handle this.";
		}
		if (currentDifficulty == 45f)
		{
			difficultyText.text = "Hard : No pain, no gain!";
		}
	}
	public void OnEasyClicked()
	{
		// PlayerPrefs.SetInt("Difficulty", PlayerPrefs.GetInt("Points", 0));
		PlayerPrefs.SetFloat("Difficulty", 15f);
		difficultyText.text = "Easy : Please hold my hand.";
	}

	public void OnNormalClicked()
	{
		PlayerPrefs.SetFloat("Difficulty", 30f);
		difficultyText.text = "Normal : I can handle this.";
	}

	public void OnHardClicked()
	{
		PlayerPrefs.SetFloat("Difficulty", 45f);
		difficultyText.text = "Hard : No pain, no gain!";
	}
}
