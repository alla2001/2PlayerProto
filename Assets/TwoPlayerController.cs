using UnityEngine;

public class TwoPlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;

    private Vector3 player1Direction;
    private Vector3 player2Direction;

    void Update()
    {
        // Player 1 input
        player1Direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
            player1Direction += Vector3.forward;
        if (Input.GetKey(KeyCode.S))
            player1Direction += Vector3.back;
        if (Input.GetKey(KeyCode.A))
            player1Direction += Vector3.left;
        if (Input.GetKey(KeyCode.D))
            player1Direction += Vector3.right;

        // Player 2 input
        player2Direction = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
            player2Direction += Vector3.forward;
        if (Input.GetKey(KeyCode.DownArrow))
            player2Direction += Vector3.back;
        if (Input.GetKey(KeyCode.LeftArrow))
            player2Direction += Vector3.left;
        if (Input.GetKey(KeyCode.RightArrow))
            player2Direction += Vector3.right;
    }

    void FixedUpdate()
    {
        // Calculate combined direction
        Vector3 moveDirection = player1Direction + player2Direction;
        moveDirection = moveDirection.normalized;

        // Apply movement to the Rigidbody
        rb.velocity = moveDirection * speed;
    }
}