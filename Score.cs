using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Player;
    public Text scoreText;
    static private float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision) {

    	if(collision.gameObject.tag == "Bumper") {
        score += 500;
        scoreText.text = score.ToString();
    	}

      if(collision.gameObject.tag == "Triangle") {
        score += 25;
        scoreText.text = score.ToString();
    	}

      if(collision.gameObject.tag == "Band") {
    		score += 100;
        scoreText.text = score.ToString();
    	}



    }
}
