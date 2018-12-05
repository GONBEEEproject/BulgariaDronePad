using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Sockets;
using System.Text;

public class MinTest : MonoBehaviour {

    public Text distanceText;
    private int distance;

    public Text speedText;
    private int speed;

    public Text leftrightText;
    private int leftright;

    public Text forbackText;
    private int forback;

    public Text updownText;
    private int updown;

    public Text yawText;
    private int yaw;

    private static string host = "192.168.10.1";
    private static int port = 8889;
    private static UdpClient client = new UdpClient();

    // Use this for initialization
    void Start () {
        client.Connect(host, port);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    /// <summary>
    /// Telloに接続
    /// </summary>
    public void Connect()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("command");
        client.Send(dgram, dgram.Length);
        Debug.Log("entry SDK mode");
    }

    /// <summary>
    /// 離陸
    /// </summary>
    public void TakeOff()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("takeoff");
        client.Send(dgram, dgram.Length);
        Debug.Log("Tello auto takeoff");
    }

    /// <summary>
    /// 着陸
    /// </summary>
    public void Land()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("land");
        client.Send(dgram, dgram.Length);
        Debug.Log("Tello auto land");
    }

    /// <summary>
    /// 緊急停止
    /// </summary>
    public void EmergencyStop()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("emergency");
        client.Send(dgram, dgram.Length);
        Debug.Log("Stop all motors immediately");
    }

    public void Up()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("up " + distance.ToString());
        client.Send(dgram, dgram.Length);

    }

    public void Down()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("down " + distance.ToString());
        client.Send(dgram, dgram.Length);

    }

    public void Left()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("left " + distance.ToString());
        client.Send(dgram, dgram.Length);

    }

    public void Right()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("right " + distance.ToString());
        client.Send(dgram, dgram.Length);

    }

    public void Forward()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("forward " + distance.ToString());
        client.Send(dgram, dgram.Length);
    }

    public void Backward()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("back " + distance.ToString());
        client.Send(dgram, dgram.Length);
    }

    public void FlipL()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("flip l");
        client.Send(dgram, dgram.Length);
    }

    public void FlipR()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("flip r");
        client.Send(dgram, dgram.Length);
    }

    public void FlipF()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("flip f");
        client.Send(dgram, dgram.Length);
    }

    public void FlipB()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("flip b");
        client.Send(dgram, dgram.Length);
    }


    public void SetSpeed()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("speed " + speed.ToString());
        client.Send(dgram, dgram.Length);
    }

    public void rcABCD()
    {
        byte[] dgram = Encoding.UTF8.GetBytes("rc " + leftright.ToString() + " " + forback.ToString() + " " + updown.ToString() + " " + yaw.ToString());
        client.Send(dgram, dgram.Length);
    }

    public void OnDistanceValueChange(float value)
    {
        distance = (int)value;
        distanceText.text = value.ToString();
    }

    public void OnSpeedValueChange(float value)
    {
        speed = (int)value;
        speedText.text = value.ToString();
    }

    public void OnleftrightValueChange(float value)
    {
        leftright = (int)value;
        leftrightText.text = value.ToString();
    }

    public void OnforbackValueChange(float value)
    {
        forback = (int)value;
        forbackText.text = value.ToString();
    }

    public void OnupdownValueChange(float value)
    {
        updown = (int)value;
        updownText.text = value.ToString();
    }

    public void OnyawValueChange(float value)
    {
        yaw = (int)value;
        yawText.text = value.ToString();
    }
}
