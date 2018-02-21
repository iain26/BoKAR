using UnityEngine;

public class SimpleController : MonoBehaviour
{
	public float speed = 6.0F;
	public float gravity = 20.0F;

    float Horizontal = 0;
    float Vertical = 0;

    private Vector3 moveDirection = Vector3.zero;
	public CharacterController controller;

	void Start(){
		// Store reference to attached component
		controller = GetComponent<CharacterController>();
	}

    public void MoveUp()
    {
        Vertical = 1;
        while (Input.GetMouseButtonDown(0))
        {
            Vertical = 1;
        }
    }

    public void MoveDown()
    {
        Vertical = -1;
        while (Input.GetMouseButtonDown(0))
        {
            Vertical = -1;
        }
    }

    public void MoveLeft()
    {
        Horizontal = -1;
        while (Input.GetMouseButtonDown(0))
        {
            Horizontal = -1;
        }
    }

    public void MoveRight()
    {
        Horizontal = 1;
        while (Input.GetMouseButtonDown(0))
        {
            Horizontal = 1;
        }
    }

    void Update() 
	{
		// Use input up and down for direction, multiplied by speed
		moveDirection = new Vector3(Horizontal, 0, Vertical);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		

		// Move Character Controller
		if(moveDirection.magnitude > 0.001)
			controller.Move(moveDirection * Time.deltaTime);

	}
}