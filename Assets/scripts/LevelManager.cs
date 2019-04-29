using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
     public static LevelManager instance = null;
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
        uicomponents.hud.txtHealthCount.text = "x " + sceneData.healthCount;

    }

    public void DecreaseHealth()
    {
        sceneData.healthCount = sceneData.healthCount - 1;

    }

    public void SetTapeSpeed(float value){ 
        TapeSpeed = new Vector3(value, TapeSpeed.y, TapeSpeed.z);
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
        sceneData.coinCount = 0;
        sceneData.healthCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
        DisplayHudData();

    }

    public void ShowLCPanel(){
        uicomponents.levelCompletePanel.lcpanel.SetActive(true);
        uicomponents.levelCompletePanel.txtScore.text = "" + sceneData.coinCount;
    }

    public void ShowGOPanel(){
        uicomponents.gameoverpanel.gopanel.SetActive(true);
        uicomponents.gameoverpanel.txtScore.text = "" + sceneData.coinCount;
    }
}
