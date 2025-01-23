using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0);
        transform.position += movement * speed * Time.deltaTime;
    }
}
