using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornoGames : MonoBehaviour
{
    public string firstName;
    public int birthDate;
    public string lastName;

    // Start is called before the first frame update
    void start()
    {
        if (birthDate >= 2019)
        {
            birthDate = 2018;
        }
        else if (birthDate <= 1900)
        {
            birthDate = 1901;
        }


        print("Hello " + firstName);
        print("Your name has " + firstName.Length + " leters.");
        print("Your initials are: " + firstName[0] + lastName[0]);
        print("You have been born for: " + (2019 - birthDate) + " years.");
    }

    // Update is called once per frame
    void Update()
    {


    }
}

