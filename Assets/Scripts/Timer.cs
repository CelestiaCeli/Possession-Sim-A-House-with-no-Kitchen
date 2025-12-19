using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float MaxTime = 15;
    float CurrentTime = 0;
    public bool TimerFinished = true;
    public UnityEvent TimerFin;

    public void Activate()
    {
        TimerFinished = false;
        CurrentTime = 0;
    }

    private void Update()
    {
        if (TimerFinished == false)
        {
            CurrentTime += Time.deltaTime;
            if (CurrentTime > MaxTime) 
            {
                print(CurrentTime);
                TimerFinished = true;
                TimerFin.Invoke();
            }
        }
    }
}
