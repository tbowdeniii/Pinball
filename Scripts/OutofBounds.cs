using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutofBounds : MonoBehaviour
{
    public GameObject Player;
    public string newGameScene;

    private int lifeCount;
    private Vector3 startingPos;
    // Start is called before the first frame update
    void Start()
    {
      startingPos = Player.transform.position;
      lifeCount = 2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision) {

    	if(collision.gameObject.tag == "Player") {
    	  if(lifeCount == 0)
          SceneManager.LoadScene(newGameScene);
        else
        {
          Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    		  Player.transform.position = startingPos;
          lifeCount--;
        }
    	}

    }
}
