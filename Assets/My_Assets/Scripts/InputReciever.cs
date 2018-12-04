using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nimushiki.BulgariaPad;
using GON.TelloController;

public class InputReciever : MonoBehaviour {

    private bool StartControll=false;


    // Use this for initialization
    void Start() {

        BulgariaPadInput.ResetPosition();
        Controller.Initialize();

    }

    // Update is called once per frame
    void Update() {

        if (!StartControll) return;

        if (BulgariaPadInput.ButtonA)
        {
            Controller.Up(50);
        }

        if (BulgariaPadInput.ButtonB)
        {
            Controller.Down(50);
        }

        if (BulgariaPadInput.Vertical != 0 && BulgariaPadInput.OnAnalogPad)
        {
            Controller.Forward((int)BulgariaPadInput.Vertical * 100);
        }

        if (BulgariaPadInput.Horizontal != 0 && BulgariaPadInput.OnAnalogPad)
        {
            Controller.Right((int)BulgariaPadInput.Horizontal * 100);
        }

    }

    public void Connect()
    {
        Controller.Connect();
        StartControll = true;
    }

    public void Takeoff()
    {
        Controller.TakeOff();
    }

    public void Land()
    {
        Controller.Land();
    }




}
