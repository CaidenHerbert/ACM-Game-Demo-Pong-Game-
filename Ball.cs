using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Caiden Herbert

public class Ball : MonoBehaviour
{
    [SerializeField] int xStartingOffset = 50;

    [SerializeField] float xVelocity = 2;
    float yVelocity = -2;

    // Called by PhysicsManager each FixedUpdate
    public void Move()
    {
        transform.position = new Vector2(xVelocity + transform.position.x, yVelocity + transform.position.y);
    }

    public void FlipXVelocity()
    {
        xVelocity = -xVelocity;
    }

    public void SetXVelocity(int sign)
    {
        xVelocity = 2 * Mathf.Sign(sign);
    }

    public void FlipYVelocity()
    {
        yVelocity = -yVelocity;
    }

    // Input Paddle's y-coord center point
    public void SetYVelocity(int paddleCenter)
    {
        float ballCenter = 2 + transform.position.y;

        yVelocity = (float)(ballCenter - paddleCenter) / 3f;

        float offset = Mathf.Abs(ballCenter - paddleCenter);
        float sign = Mathf.Sign(ballCenter - paddleCenter);
        switch (offset)
        {
            case < 3f:
                yVelocity = 0 * sign;
                break;
            case < 4f:
                yVelocity = 0.5f * sign;
                break;
            case < 5f:
                yVelocity = 1f * sign;
                break;
            case < 6f:
                yVelocity = 1.5f * sign;
                break;
            case < 7f:
                yVelocity = 2f * sign;
                break;
            case < 9f:
                yVelocity = 2.5f * sign;
                break;
            default:
                yVelocity = 3f * sign;
                break;
        }
    }

    // Input player who scored to decide starting direction
    public void ResetBallPosition(int player)
    {
        // Set Ball's position on the side of who scored
        if (1 == player)
        {
            transform.position = new Vector2(100 - xStartingOffset, 75);
            // Set Ball's x velocity in the positive direction
            SetXVelocity(1);
        }
        else
        {
            transform.position = new Vector2(100 + xStartingOffset, 75);
            // Set Ball's x velocity in the negative direction
            SetXVelocity(-1);
        }
    }
}