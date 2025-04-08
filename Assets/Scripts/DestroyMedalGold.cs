using System;
using UnityEngine;

public class DestroyMedalGold : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int counter = 0;

        if (collision.gameObject.tag == "Player")
        {
            counter++;
            Debug.Log(counter);
            Destroy(this.gameObject);
        }
    }
}