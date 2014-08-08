using UnityEngine;
using System.Collections;

public class MoveUpDownLeftRight : MonoBehaviour {

	public float speed = 10.0f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		transform.position += Vector3.up * Input.GetAxis ("Vertical") * Time.deltaTime * speed;
	}
}
