using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SceneData
{
    public static SceneData instance = null;
    public int coinCount;
    public int healthCount;
    
    void Awake(){
        if (instance == null)
        {
            instance = this;
        }
    }
}
