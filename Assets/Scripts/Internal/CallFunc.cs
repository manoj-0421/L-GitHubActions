using UnityEngine;
using com.glance.interl;
namespace com.glance.inter
{
    public class CallFunc : MonoBehaviour
    {
        private InternalFunc func;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            func = new InternalFunc();
            int a = func.AddFunc(4,5,Mode.Add);

            a = func.AddFunc(150,50,Mode.Minus);

            a = func.AddFunc(15,3,Mode.Multiply);
            a = func.AddFunc(48,8,Mode.Divide);
            float b = func.AddFunc(49.0f,8,Mode.Divide);
        }
    }
}