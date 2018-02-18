using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Score score;
	public GameObject gameCompleteUI;
	public GameObject completeLevelUI;
	public GameObject failedLevelUI;

	private int levelMaxIndex = 1;
	private bool gameHasEnded = false;

	public void LevelComplete() {
		if (SceneManager.GetActiveScene ().buildIndex == levelMaxIndex) {
			// end of the game
			gameCompleteUI.SetActive(true);
		} else {
			// next level
			completeLevelUI.SetActive(true);
		}
	}

	// end the game
	public void EndGame() {

		if(!gameHasEnded) {
			// disable counting score
			score.enabled = false;

			// set gameHasEnded
			gameHasEnded = true;

			Invoke("showFailedLevelUI", 2f);
		}
	}

	private void showFailedLevelUI() {
		failedLevelUI.SetActive(true);
	}

	// restart the game
	public void RestartGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
