using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{
    public Transform sphere;
    public GatherCube scoreScript;
    // Update is called once per frame
    void Update()
    {
        if (sphere.position.y < 0 || scoreScript.score == 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
