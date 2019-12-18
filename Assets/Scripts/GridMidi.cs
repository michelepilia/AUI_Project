using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MidiPlayerTK;

public class GridMidi : MonoBehaviour
{
    public MidiStreamPlayer midiStreamPlayer;
    public int midiNote;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void TaskOnClick()
    {

        /*MPTKEvent notePlaying = new MPTKEvent()
        {
            Command = MPTKCommand.NoteOn,
            Value = midiNote,
            Duration = 1,
            Velocity = 100
        };
        midiStreamPlayer.MPTK_PlayEvent(notePlaying);
        Debug.Log("Playing note " + midiNote);*/


        midiStreamPlayer.MPTK_PlayEvent(new MPTKEvent()
        {
            Channel = 9,
            Duration = (long)0.5,
            Value = 60,
            Velocity = 100
        });
        Debug.Log("Playing note " + midiNote);



    }
}
