using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionProbeController : MonoBehaviour
{
    public ReflectionProbe ProbeRef;

    public void RenderProbe()
    {
        if (ProbeRef != null)
        {
            ProbeRef.RenderProbe();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderProbe();
    }
}
