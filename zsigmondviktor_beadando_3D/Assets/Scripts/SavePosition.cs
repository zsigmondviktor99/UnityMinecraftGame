using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

class SaveData
{
    public float x;
    public float y;
    public float z;

    public SaveData(float X, float Y, float Z)
    {
        x = X;
        y = Y;
        z = Z;
    }
}
public class SavePosition : MonoBehaviour
{
    public Rigidbody player;

    private void OnApplicationQuit()
    {
        File.WriteAllText("save.json", JsonUtility.ToJson(new SaveData(player.position.x, player.position.y, player.position.z)));
    }

    private void Awake()
    {
        SaveData pos = JsonUtility.FromJson<SaveData>(File.ReadAllText("save.json"));
        player.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
