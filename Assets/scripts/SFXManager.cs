using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    // Start is called before the first frame update


    public static SFXManager instance;
    public GameObject CoinParticles;
    public GameObject DieParticles;

    void Awake()
    {
      if (instance == null){
          instance = this;
      }  
    }
    public void ShowCoinParticles(GameObject obj){
        Instantiate(CoinParticles, obj.transform.position, Quaternion.identity);
        
    }

    public void ShowDieParticles(GameObject obj){
        Instantiate(DieParticles, obj.transform.position, Quaternion.identity);
        
    }
}
    

