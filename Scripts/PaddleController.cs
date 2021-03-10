using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public float restPosition, pressedPosition, flipperStrength, flipperDamper;

    public string inputButtonName;

    private JointSpring spring;
    // Start is called before the first frame update
    void Start()
    {

      GetComponent<HingeJoint>().useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
      spring.spring = flipperStrength;
      spring.damper = flipperDamper;

      if(Input.GetButton(inputButtonName))
        spring.targetPosition = pressedPosition;
      else
        spring.targetPosition = restPosition;

      GetComponent<HingeJoint>().spring = spring;
      GetComponent<HingeJoint>().useLimits = true;
      JointLimits limits = GetComponent<HingeJoint>().limits;
      limits.min = restPosition;
      limits.max = pressedPosition;
      
    }
}
