using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
    public int pointValue;
    public ParticleSystem explostionParticle;
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (gameManager.isGameActive)
        {
        Destroy(gameObject);
        gameManager.UpdateScore(pointValue);
        Instantiate(explostionParticle, transform.position, explostionParticle.transform.rotation);
        }
        
    }
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        if(!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(12, 18);
    }
    float RandomTorque()
    {
        return Random.Range(-10, 10);
    }
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-4 ,4), -2);
    }
}
