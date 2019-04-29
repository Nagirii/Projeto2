using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[Serializable]

public class UIcomponents
{
    [Serializable]
    public class Hud{
        [Header("Text")]
        public Text txtCoinCount;
        public Text txtHealthCount;
          [Header("Other")]
        public GameObject panelHud;
    }
       [Serializable]
       public class LevelCompletePanel{ 
        
        [Header("Text")]
        public Text txtScore;
        [Header("Other")]
        public GameObject lcpanel;
       }
      

    
    public Hud hud;
    public LevelCompletePanel levelCompletePanel;
    

}
