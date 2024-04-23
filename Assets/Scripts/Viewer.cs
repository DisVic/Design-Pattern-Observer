using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]private ScoreController scoreController;


    void Update()
    {
        if (scoreController.currentScore == 50)
        {
            EventManager.RaiseAddPoints(100);
            Debug.Log("Good job!");
        }
    }
}
