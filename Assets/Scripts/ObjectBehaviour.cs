using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    private ScoreScript scoreScript;
    private GameManager gameManager;
    [SerializeField] GameObject prefab;
    bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Find the GameManager script
        scoreScript = FindObjectOfType<ScoreScript>();
    }


    public void SpawnObject()
    {
        Instantiate(prefab, new Vector3(Random.Range(-8f, 8f), 8f, 0f), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !gameOver)
        {
            SpawnObject();
            scoreScript.Play();
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "Ground")
        {
            if (gameManager != null)
            {
                gameManager.OnObjectFall(); // Call GameManager's method to trigger game over
            }
            Destroy(gameObject); // Destroy the fallen object
        }
    }
}