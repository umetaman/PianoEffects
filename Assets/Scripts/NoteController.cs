using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using MidiJack;

public class NoteController : MonoBehaviour
{
    public VisualEffect vfxRef;

    // Start is called before the first frame update
    void Start()
    {
        MidiMaster.noteOnDelegate = OnNoteReceived;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNoteReceived(MidiChannel channel, int note, float velocity)
    {
        vfxRef.SetVector3("GeneratePosition", new Vector3(note * 0.1f, 0, 0));
        vfxRef.SendEvent("Note");
    }
}
