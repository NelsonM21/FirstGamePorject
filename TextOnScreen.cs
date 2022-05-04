using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextOnScreen : MonoBehaviour
{
    public TextMeshPro sceneText;
    public TextMeshPro numberText;

    public GameObject whiteCube;

    public bool gameWin = false;

    public CollisionDectector collisionScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {
        if (collisionScript.hitCounter >= 5)
        {
            sceneText.text = "The player gotten all the dabloons.";
            Destroy(whiteCube);
            numberText.text = collisionScript.hitCounter.ToString();
            WinFunction();
        }
        else
        if (collisionScript.hitCounter < 5)
        {
            print("Hit the white block to win.");
        }
        void WinFunction()
        {
            print("I have been called!!");
        }
    }
}
