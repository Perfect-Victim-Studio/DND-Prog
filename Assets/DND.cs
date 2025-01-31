using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using NUnit.Framework;

//character's name (string)
//proficiency bonus(int)
//using a finesse weapon(bool)
//STR(strength) modifier(int, from - 5 to + 5)
//DEX(dexterity modifier(int, from - 5 to + 5)

//AC 10-20 (10-20) +1
//D20 random (0-20) +1

public class DND : MonoBehaviour
{
    //Define

    [SerializeField] string char_name;
    [SerializeField] int prof_bonus;
    [SerializeField] bool fin_weap;
    [SerializeField] [UnityEngine.Range(-5, 5)] int str_mod;
    [SerializeField] [UnityEngine.Range(-5, 5)] int dex_mod;


    void Start()
    {
        //Randoms
        int D20 = Random.Range(0, 20) +1;
        int AC = Random.Range(10, 20) + 1;

        //Hit Mod Math

        int hit_mod;

        if (str_mod > dex_mod)
        {
            hit_mod = str_mod + prof_bonus;
        }
        else {hit_mod = dex_mod + prof_bonus;}

        //Hit?

        bool hit = false;

        if (D20 + hit_mod < AC)
        {
            hit = false;
        }
        else {  hit = true; }


        // Print

        Debug.Log("Your hit modifier is: " + hit_mod);
        Debug.Log("Enemies AC is: " + AC);
        Debug.Log("You rolled: " + D20);
        if (fin_weap == true) {
            Debug.Log("You are using a finesse weapon! ");

            if (str_mod > dex_mod)
            {
                Debug.Log("Your Strength Modifier is higher!");
            }
            else { Debug.Log("Your Dexterity Modifier is higher!");}
        }
        if (hit == true)
        {
            Debug.Log("Congrats, you hit! ");
        }
        else { Debug.Log("You missed :( "); }
    }

    void Update()
    {
 
    }
}
