using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using TouchScript.Hit;
using DG.Tweening;


public class PlaneGestureManager : MonoBehaviour
{

    public TapGesture singleTap;
    public TapGesture doubleTap;

    public Animator unitychan;
    public Animator charactertwo;

    // Use this for initialization
    void Start()
    {

        singleTap.Tapped += (object sender, System.EventArgs e) =>
        {
            TouchHit hit;
            singleTap.GetTargetHitResult(out hit);
            print("QQ");
            unitychan.SetTrigger("singletap");
            charactertwo.SetTrigger("singletaptwo");

        };

        doubleTap.Tapped += (object sender, System.EventArgs e) =>
        {
            TouchHit hit;
            doubleTap.GetTargetHitResult(out hit);

            unitychan.SetTrigger("doubletap");
            charactertwo.SetTrigger("doubletaptwo");

        };
    }
}
