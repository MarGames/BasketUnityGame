using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
  
    

    public GameObject sphere;
    public Text scoretxt;
    public int score = 0;
    public GameObject goal1;
    public GameObject goal2;
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {

        highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        scoretxt.GetComponent<Text>().text = "" + score;
    }
    private void Update()
    {
        transform.position = new Vector3(sphere.transform.position.x, sphere.transform.position.y, sphere.transform.position.z);
    }
    private void OnTriggerExit(UnityEngine.Collider Player)
    {
        if (Player.tag == "goal")
        {

            goal1.transform.position = new Vector3(goal1.transform.position.x, Random.Range(0.5f, 4f), goal1.transform.position.z);

            score++;
            scoretxt.GetComponent<Text>().text = "" + score;
        }
        if (Player.tag == "goal2")
        {
            goal2.transform.position = new Vector3(goal2.transform.position.x, Random.Range(0.5f, 4f), goal2.transform.position.z);

            score++;
            scoretxt.GetComponent<Text>().text = "" + score;
        }
        if (score > 3)
        {
            Vibration.Vibrate(100);
        }
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highscore.text = score.ToString();
        }

    }
}
