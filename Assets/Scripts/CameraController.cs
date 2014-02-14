using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	/// <summary>
	/// Reference to the Player object in the Unity scene.
	/// </summary>
	public GameObject player;

	/// <summary>
	/// The Camera's relative position to the Player object.
	/// </summary>
	private Vector3 offset;

	// Use this for initialization
	void Start() 
	{
		// Initially offset is the camera's original position.
		offset = transform.position;
	}
	
	// A follow camera should only be implemented in a LateUpdate method,
	// according to Unity docs.
	void LateUpdate() 
	{
		transform.position = player.transform.position + offset;
	}
}
