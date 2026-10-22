using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("=== パラメータ設定.")]
    public float MoveSpeed = 5;     // 基本移動速度
    public float RotSpeed = 90;     // 基本旋回速度

    void Start()
    {
        
    }

    void Update()
    {
        if(Keyboard.current.aKey.IsPressed())
        {
            transform.Rotate(Vector3.up * -RotSpeed * Time.deltaTime);
        }
        if(Keyboard.current.dKey.IsPressed())
        {
            transform.Rotate(Vector3.up * RotSpeed * Time.deltaTime);
        }
        if(Keyboard.current.wKey.IsPressed())
        {
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }
        if(Keyboard.current.sKey.IsPressed())
        {
            transform.Translate(Vector3.forward * -MoveSpeed * Time.deltaTime);
        }
    }
}
