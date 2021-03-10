using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperObject : MonoBehaviour
{
    public float bumperStrength = 100;
    private Rigidbody rb;

    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
      Vector3 explosionPos = transform.position;
      Collider[] colliders = Physics.OverlapSphere(explosionPos, 3);

      foreach (Collider hit in colliders)
      {
          Rigidbody rb = hit.GetComponent<Rigidbody>();

          if (rb != null)
            rb.AddExplosionForce(bumperStrength, explosionPos, 3);
      }
    }
}
