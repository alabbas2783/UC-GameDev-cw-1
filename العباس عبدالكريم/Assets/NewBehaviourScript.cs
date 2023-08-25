using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroname = "NARUTO";
        int heroage = 23;
        float heroHeight = 1.93f;
        string heroSUPERpower = "RASINGAN";


        string villainname = "MADARA";
        int villainAge = 35;
        float vililanHeight = 2.14f;
        string villainSuperPower = "RENGAN";

        int ageDifference = villainAge - heroage;

       
        
        print("hero name is " +heroname + " hero age is " + heroage+ " hero Height is " + heroHeight+ " hero SUPER power is " + heroSUPERpower);
        print(" villain name is " + villainname + " villain Age is " + villainAge + " vililan Height is " + vililanHeight + " villain Super Poweris " + villainSuperPower);
        print("age Difference is " + ageDifference);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
