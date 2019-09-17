using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 1.5f;
    public Animator anim;
//    public SpriteRenderer lol;

//    private void Start()
//    {
//        anim = GetComponent<Animator>();
//    }

    private void Update ()
	{
		if (Input.GetKey(KeyCode.A))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
        }
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
}