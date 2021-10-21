using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherCube : MonoBehaviour
{
    public int score = 0;
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        score = score + 1;
        //other.gameObject.SetActive(false);
        Destroy(other.gameObject);
        text.text = "Score: " + score;
    }
}
