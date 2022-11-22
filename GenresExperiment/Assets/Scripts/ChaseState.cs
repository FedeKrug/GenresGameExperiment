public class ChaseState : State
{
    public bool inAttackRange;
    public State attackState;


    public override State RunCurrentState()
    {
        if (inAttackRange)
        {
            return attackState;
        }
        else
        {
            return this;

        }
    }
}
