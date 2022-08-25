using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class DayNightCycle : MonoBehaviour
{
    public float daySpeed;
    public float brightness = 1;

    private void Update()
    {

        GetComponent<Light2D>().intensity = brightness;
    }
}
