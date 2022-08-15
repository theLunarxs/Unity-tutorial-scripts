using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public bool hasPowerUp;
    private float powerupstrength = 20.0f;
    public GameObject powerIndicator;
    
    void Start()
    {
     playerRb = GetComponent<Rigidbody>();
     focalPoint = GameObject.Find("FocalPoint");
     
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        powerIndicator.transform.position = transform.position;
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Powerup"))
        {
        Destroy(other.gameObject);
        hasPowerUp = true;
        StartCoroutine(PowerUpCountdown());
        powerIndicator.gameObject.SetActive(true);
        }
        
    }
    IEnumerator PowerUpCountdown(){
        yield return new WaitForSeconds(7);
        hasPowerUp= false;
         powerIndicator.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Enemy")&& hasPowerUp)
        {
        Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
        Vector3 awayfromPlayer =  other.gameObject.transform.position - transform.position;
        enemyRigidbody.AddForce(awayfromPlayer * powerupstrength, ForceMode.Impulse);
        }
    }
}
