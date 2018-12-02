using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GON.TelloControll;

public class TelloReciever : MonoBehaviour {

    Controller controller = new Controller();

    [SerializeField]
    private int MoveSpeed = 1;

    private void Start()
    {
        controller.Initialize();
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




}
