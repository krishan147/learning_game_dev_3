using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private Transform camTransform;

    public GameObject directionLight;
    private Transform lightTransform;

    void Start()
    {
        int playerLives = 10;

        while (playerLives > 0)
        {
            Debug.Log("Still alive!!!!!");
            playerLives--;
        }

        Debug.Log("Player koooo'dd");

        Character hero = new Character();
        /*Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);*/
        hero.PrintStatsInfo();
        
        Character heroine = new Character("Agatha");
        /*Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);*/
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = new Weapon("crazy Bow", 2);
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Character hero2 = hero;
        hero2.name = "the cool cat";
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();

        Paladin knight = new Paladin("sir megacool", huntingBow);
        knight.PrintStatsInfo();

        //directionLight = GameObject.Find("Directional Light");

        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }

    void GetComponentExample()
    {
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);
 
    }

}