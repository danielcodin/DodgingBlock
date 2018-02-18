using UnityEngine;

public class focusPlayer : MonoBehaviour {

	public Transform playerTransform;
	public float yOffset;
	public float zOffset;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (0, playerTransform.position.y + yOffset, playerTransform.position.z + zOffset);
	}
}
