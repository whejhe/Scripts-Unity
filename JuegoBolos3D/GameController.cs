using UnityEngine;

public class GameController : MonoBehaviour
{
    public BallController ball;
    public PinManager pinManager;
    public Transform ballStartPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Reinicia la escena
        {
            ResetTurn();
        }
    }

    void ResetTurn()
    {
        ball.ResetBall(ballStartPosition.position);
        pinManager.ResetPins();
    }
}
