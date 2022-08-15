using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public float SpawnRate = 1.0f;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnDelay()
    {
        while(isGameActive)
        {
        yield return new WaitForSeconds(SpawnRate);
        int index = Random.Range(0, targets.Count);
        Instantiate(targets[index]);
        }
        
    }

    public void UpdateScore(int ScoreToAdd)
    {
        score += ScoreToAdd;
        scoreText.text = string.Format("Score: {0}", score);
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        StartCoroutine(SpawnDelay());
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        SpawnRate /= difficulty;
    }
}
