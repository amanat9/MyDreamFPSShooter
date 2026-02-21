using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float bulletSpan = 5;
    public Player myPlayer;    ///////////////////////////1

    // Start is called before the first frame update
    void Awake()
    {
        //myPlayer = GameObject.Find("Player").GetComponent<Player>();
        Destroy(gameObject, bulletSpan);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false); // option 2:  Destroy(other.gameObject);
        Debug.Log("It was trigger");
        Destroy(gameObject);
        myPlayer.numOfEnemierDestoryed++;     ////////////////////////////////2 
    }

 


    // Update is called once per frame
    void Update()
    {
        
    }
}
