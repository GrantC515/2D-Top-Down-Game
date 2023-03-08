using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("Coin Count") != null)
        {
            Debug.Log("I found the Coin Count");
            GameObject.Find("Coin Count").GetComponent<TextMeshProUGUI>;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void RaceButtonPressed()
    {
        SceneManager.LoadScene("Game Mode");
    }

    public void SingleRaceButtonPressed()
    {
        SceneManager.LoadScene("Single Race");
    } 

    public void CupRaceButtonPressed()
    {
        SceneManager.LoadScene("Course 1");
    }
}
