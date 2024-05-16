using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelProgressBar : MonoBehaviour
{
    [SerializeField]float needPowerToCompleteLevel;
    [SerializeField]Slider progressBar;
    [SerializeField]public GameObject LevelLoader;

    public float curProgress=0;
    [HideInInspector]public bool isLevelCompleted = false;

    public float getCurrentProgress(){
        return curProgress;
    }
    void Start(){
        curProgress = 0;
        progressBar.value = curProgress;
    }

    public void LevelProgressing(float power){
        power/=2;
        curProgress +=power;
        // Debug.Log(power);
        Debug.Log("Current progress: " + curProgress);
        progressBar.value = curProgress;

        if(curProgress >= 100){
            LevelLoader.SetActive(true);
            // SceneManager.LoadScene(3);
            if(isLevelCompleted){
                 GameManager.LevelProgressBar();
                 isLevelCompleted = false;
            }

        }
    }
}
