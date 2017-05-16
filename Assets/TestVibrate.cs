using UnityEngine;
using System.Collections;

public class TestVibrate : MonoBehaviour
{

    AndroidJavaObject v;

    void Start()
    {
#if UNITY_ANDROID
        using (AndroidJavaClass p = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject a = p.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                v = a.Call<AndroidJavaObject>("getSystemService", "vibrator");
            }
        }
#endif
    }

    void Vibrate(long time)
    { // 此部分要單獨寫成方法(函式)，不可單獨呼叫
        v.Call("vibrate", time);
    }

    float t = 5;

    void Update()
    {
        if ((t += Time.deltaTime) > 0.2F)
        { // 每 0.2 秒震動一次
            t = 0;
            Vibrate(150); // 震動 0.15 秒
        }
    }

}