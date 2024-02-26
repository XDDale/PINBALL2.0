using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        switch (tag)
        {
            case "Dead":
                GameManager.instance.GameEnd();
                break;

            case "Bouncer":
                GameManager.instance.UpdateScore(10, 1);
                break;

            case "Point1":
                GameManager.instance.UpdateScore(20, 1);
                break;

            case "Point2":
                GameManager.instance.UpdateScore(10, 1);
                break;

            case "Point3":
                GameManager.instance.UpdateScore(30, 1);
                break;

            case "Flipper":
                GameManager.instance.multiplier = 1;
                break;

         
        }
    }
}
