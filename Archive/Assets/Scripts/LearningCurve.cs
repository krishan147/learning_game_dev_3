using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        string characterAction = "Heal";

        switch(characterAction)
        {
            case "Heal":
                Debug.Log("potion sent");
                break;
            case "Attack":
                Debug.Log("to arms");
                break;
            default:
                Debug.Log("shields up");
                break;
        }

    }

}
