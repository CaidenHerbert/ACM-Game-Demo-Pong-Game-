using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Caiden Herbert

public class Score : MonoBehaviour
{
    int player1Score = 0;
    int player2Score = 0;

    // List of the display numbers 0 - 9
    [SerializeField] List<GameObject> player1Display;
    [SerializeField] List<GameObject> player2Display;

    // Input player number of who scored, returns TRUE if game is over
    public bool IncreaseScore(int player)
    {
         HideCurrentScore();

        if((player1Score + 1) >= 10 || (player2Score) >= 10)
        {
            return true;
        }

        if(player == 1)
        {
            player1Score++;
        }

        if(player == 2)
        {
            player2Score++;
        }
    }

    // Reset score when game ends
    public void ResetScore()
    {
        if(IncreaseScore == 10)
        {
            int player1Score == 0;
            int player2Score == 0;
        }
    }

    void HideCurrentScore()
    {
        // Deactivate previous score values for P1 and P2
        player1Display[player1Score].SetActive(false);
        player2Display[player2Score].SetActive(false);
    }

    // Updates score counter in-game
    void DisplayCurrentScore()
    {
        // Activate only current score values for P1 and P2
        player1Display[player1Score].SetActive(true);
        player2Display[player2Score].SetActive(true);
    }
}