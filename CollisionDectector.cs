using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDectector : MonoBehaviour
{
    public float hitCounter = 0;
    public TextMesh numberText;
    
    // Start is called before the first frame update//
    void Start()
    {

    }
    public void OnCollisonEnter(Collision collision, TextOnScreen textOnScreen)
    {
        if (collision.gameObject.tag == "Player")
        {
            hitCounter += 1;
            print("I've been had " + hitCounter + "times");
            numberText.text = hitCounter.ToString();

            if (hitCounter >= 5)
            {
                textOnScreen.whiteCube.SetActive(false);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        hitCounter += 1;
        print("I smell the smelly smell of someone trying to take me money" + hitCounter + "times.");
    }
    // Update is called once per frame
    void Update()
    {

    }
}

