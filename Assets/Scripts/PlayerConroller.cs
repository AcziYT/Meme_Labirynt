using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
	private CharacterController characterController;
	[SerializeField] private float speed = 12f;
	private Vector3 velocity;
	
	private bool groundedPlayer;
	
	private float jumpHeight = 1.0f;
	
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
	
	void PlayerMove() 
	{
		groundedPlayer = characterController.isGrounded;
		
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		
		Vector3 move = transform.right * x + transform.forward * y;
		characterController.Move(move * speed * Time.deltaTime);
		
		if (groundedPlayer) {
			
			Debug.Log("True");
			
			if (velocity.y < 0) velocity.y = 0f;
		
		    if (Input.GetButtonDown("Jump")) 
		    {
			   velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * -9.81f);
			   Debug.Log("Jump");
		    }
		}
		
		velocity.y += -9.81f * Time.deltaTime;
		characterController.Move(velocity * Time.deltaTime);
	}
}
