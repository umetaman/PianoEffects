using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[ExecuteInEditMode]
public class GridController : MonoBehaviour
{
    public VisualEffect vfxRef;

    public Vector2 ScreenSize;
    public Vector2 ScreenPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScreenSize = new Vector2(Screen.width, Screen.height);
        ScreenPosition = Input.mousePosition;

        vfxRef.SetVector2("ScreenSize", ScreenSize);
        vfxRef.SetVector2("ScreenPosition", ScreenPosition);
    }
}
