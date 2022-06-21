using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour
{
    public GameObject enemy;
    private float timer;
    private float spawnTimer= 8f;
    public Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Vector3 pos = new Vector3(Random.Range(-420f,-142f), 3.4f, Random.Range(300f,375f));
            Instantiate(enemy, pos, Quaternion.identity);
            timer = spawnTimer;
        }
    }

    public void scoreLevel(int s)
    {
        score += s;
        scoreText.text = "" + score;
        if (score == 10)
        {
            SceneManager.LoadScene(3);
        }
    }

   
}
