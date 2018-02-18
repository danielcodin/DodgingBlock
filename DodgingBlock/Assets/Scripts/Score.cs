using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public playerMovement playerMovement;
	public Transform playerTransform;
	public Text scoreText;

	private int highestScore;

	// Use this for initialization
	void Start() {
		// initialize the score as "0"
		scoreText.text = "0";
	}

	// Update is called once per frame
	void Update() {
		// get highestScore, in case the block gets knock back
		highestScore = Mathf.Max ((int)playerTransform.position.z, highestScore);

		// display new score
		scoreText.text = highestScore.ToString ();
	}
}
