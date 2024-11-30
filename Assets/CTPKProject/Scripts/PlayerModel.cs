using System;
using MoreMountains.Feedbacks;

[Serializable]
public class PlayerModel
{
    private int health;
    private int experince;
    private int apples;

    public event Action HealthChanged;
    public event Action ExpChanged;
    public event Action ApplesChanged;

    public event Action CommonDataChanged;

    public int Health
    {
        get => health;
        set
        {
            if (value != health)
            {
                health = value;
                HealthChanged?.Invoke();
                CommonDataChanged?.Invoke();
            }
        }
    }
    
    public int Experince
    {
        get => experince;
        set
        {
            if (value != experince)
            {
                experince = value;
                ExpChanged?.Invoke();
                CommonDataChanged?.Invoke();
            }
        }
    }
    
    public int Apples
    {
        get => apples;
        set
        {
            if (value != apples)
            {
                apples = value;
                ApplesChanged?.Invoke();
                CommonDataChanged?.Invoke();
            }
        }
    }
    
    
    
}
