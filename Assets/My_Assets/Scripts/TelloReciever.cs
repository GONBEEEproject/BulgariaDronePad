using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GON.TelloControll;
using Nimushiki.BulgariaPad;

public class TelloReciever : MonoBehaviour {

    Controller controller = new Controller();

    [SerializeField]
    private int MoveSpeed = 1;

    private void Start()
    {
        BulgariaPadInput.ResetPosition();

        BulgariaPadInitializer.Instance.StartCalibration();

        controller.Initialize();
    }

    private void Update()
    {
        if (BulgariaPadInput.ButtonA)
        {
            Down();
        }

        if (BulgariaPadInput.ButtonB)
        {
            Up();
        }
    }





    public void Connect()
    {
        controller.Connect();
    }

    public void Takeoff()
    {
        controller.Takeoff();
    }

    public void Land()
    {
        controller.Land();
    }

    public void Down()
    {
        controller.Down(MoveSpeed);
    }

    public void Up()
    {
        controller.Down(-MoveSpeed);
    }


}
