using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;
//using UnityStandardAssets.Characters.ThirdPerson;

public class OSCController : MonoBehaviour
{
    #region Field

    public string serverId = "MaxMSP";
    public string serverIp = "127.0.0.1";
    public int    serverPort = 12000;

    public bool enableShowDebugLog = true;
    private long latestTimeStamp = 0;

    #endregion Field

    new Rigidbody rigidbody;
    public Vector3 move;
    public Vector3 rotation;
    public Vector3 drotation;
    Quaternion addrotation = Quaternion.identity;
    
    void Start ()
    {
        OSCHandler.Instance.Init(this.serverId, this.serverIp, this.serverPort);
        ShowDebugLog();

        GameObject GoCube= GameObject.Find("Cube");
        rigidbody = GoCube.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        OSCHandler.Instance.UpdateLogs();
   
        foreach (KeyValuePair<string, ServerLog> item in OSCHandler.Instance.Servers)
        {
            if (item.Value.packets.Count == 0)
            {
                continue;
            }

            int latestPacketIndex = item.Value.packets.Count - 1;

            if (this.latestTimeStamp == item.Value.packets[latestPacketIndex].TimeStamp)
            {
                continue;
            }

            this.latestTimeStamp = item.Value.packets[latestPacketIndex].TimeStamp;


            // 0: x
            // 1: z
            // 3: θ
            move.x = 0;// -0.866F * float.Parse(item.Value.packets[latestPacketIndex].Data[0].ToString());
            move.y = 1.7F+float.Parse(item.Value.packets[latestPacketIndex].Data[1].ToString());
            move.z =  float.Parse(item.Value.packets[latestPacketIndex].Data[0].ToString()); 
            rotation.x = -(float.Parse(item.Value.packets[latestPacketIndex].Data[3].ToString()));
            //rotation.x *= (float)(-3.1415F/180.0F);
            //rotation.y = (float)(-60.0F);
            rotation.z = 0;


            //差を使うかもしれない
            drotation.x = rotation.x - rigidbody.rotation.ToEulerAngles().x * (180.0F/3.1415F);
            drotation.y = 0;
            drotation.z = 0;

            addrotation.eulerAngles = drotation;

            //addrotation.eulerAngles = new Vector3(-1* (float.Parse(item.Value.packets[latestPacketIndex].Data[3].ToString()))- rigidbody.rotation.ToEulerAngles().x, 0,0);

            rigidbody.position = move;
            //rigidbody.MovePosition(move);
            rigidbody.rotation = Quaternion.Euler(rotation.x,0.0f, 0.0f);
            //rigidbody.Rotate = Quaternion.Euler(drotation.x, 0.0F, 0.0F);


            Debug.Log("Receive : "
                  + item.Value.packets[latestPacketIndex].TimeStamp
                  + " / "
                  + item.Value.packets[latestPacketIndex].Address
                  + " /x: "
                  + item.Value.packets[latestPacketIndex].Data[0]
                  + " /z: "
                  + item.Value.packets[latestPacketIndex].Data[1]
                  + " /theta: "
                  + item.Value.packets[latestPacketIndex].Data[3]
                  + " /theta(unity): "
                  + (rigidbody.rotation.ToEulerAngles().x * (-180F / 3.1415F)).ToString());



        }
    }

    private void ShowDebugLog()
    {
        if (this.enableShowDebugLog == false)
        {
            return;
        }

        Debug.Log("OSC (" + this.serverId + ", "
                          + this.serverIp + ", "
                          + this.serverPort + ")");
    }
}