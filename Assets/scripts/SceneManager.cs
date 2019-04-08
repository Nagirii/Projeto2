using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
     public static SceneManager instance = null;
    private Vector3 TapeSpeed = new Vector3 (-2f, 0f, 0f);
    [SerializeField]
    private Transform Tape = null;

    public UIcomponents uicomponents;

    SceneData sceneData = new SceneData();
    public void IncrementCoinCount()
    {
        sceneData.coinCount = sceneData.coinCount + 1;

    }
    void DisplayHudData()
    {
        uicomponents.hud.txtCoinCount.text = "x " + sceneData.coinCount;

    }

    void Awake(){
        Assert.IsNotNull(Tape);
        if(instance == null){
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        DisplayHudData();

    }
}
