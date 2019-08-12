using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private float timeLeft = 120;
    public int playerScore = 0;
    public GameObject timeUI;
    public GameObject scoreUI;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        scoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        //Debug.Log(timeLeft);
        if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene("Main");
        }
    }

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.name == "door")
        {
            CountScore();
        }
        if(trig.gameObject.name == "icy")
        {
            playerScore += 200;
            Destroy(trig.gameObject);
        }
    }

    void CountScore()
    {
        playerScore = playerScore + (int)(timeLeft * 10);
    }
}
