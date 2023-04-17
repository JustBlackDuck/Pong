using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    
    public GameManager game;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        game.StartRound();
    }


}
