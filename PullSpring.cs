using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSpring : MonoBehaviour
{

    public float distance = 50;
    public float speed = 1;
    public float power = 10;
    public string inputButtonName = "Pull";
    public float radius = 5.0F;
    public GameObject Player;

    private bool ready = true;
    private bool fire = true;
    private float moveCount = 0;





    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
      if(Input.GetButton(inputButtonName)){
        //As the button is held down, slowly move the piece
        if(moveCount < distance){
          transform.Translate(0,0,-speed * Time.deltaTime);
          moveCount += speed * Time.deltaTime;

        }
      }
      else if(moveCount > 0){
        //Shoot the ball
        if(fire && ready){
          Player.transform.TransformDirection(Vector3.forward * 10);
          Player.GetComponent<Rigidbody>().AddForce(moveCount * power, 0, 0);

        }
        //Once we have reached the starting position fire off!
        transform.Translate(0,0,20 * Time.deltaTime);
        moveCount -= 20 * Time.deltaTime;

      /*  Vector3 explosionPos = new Vector3(transform.position.x, transform.position.y+2, transform.position.z);
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 0.0F);
        } */
      }

      //Just ensure we don't go past the end
      if(moveCount <= 0){

        moveCount = 0;
      }
    }
}
