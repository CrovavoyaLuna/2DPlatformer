using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //Плюс к прыжку когда в коллайдере
        other.GetComponent<Jump>().jumpStrength += 10;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        //Минус к прыжку когда не в коллайдере
        other.GetComponent<Jump>().jumpStrength -= 10;
    }
}
