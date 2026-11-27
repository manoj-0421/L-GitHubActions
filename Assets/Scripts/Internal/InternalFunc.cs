using UnityEngine;

namespace com.glance.interl
{
    internal enum Mode
    {
        None,
        Add,
        Minus,
        Multiply,
        Divide
    }
    internal class InternalFunc
    {
        internal int AddFunc(int a, int b, Mode mode)
        {
            int c = 0;
            switch(mode)
            {
                case Mode.Add:
                c = a+b;
                break;
                case Mode.Minus:
                c = a-b;
                break;
                case Mode.Multiply:
                c = a*b;
                break;
                case Mode.Divide:
                c = a/b;
                break;
                default:
                // Debug.LogError("Default Value");
                break;
            }
            // Debug.LogError($"Value {c}");
            return c;
        }

        internal float AddFunc(float a, float b, Mode mode)
        {
            float c = 0;
            switch(mode)
            {
                case Mode.Add:
                c = a+b;
                break;
                case Mode.Minus:
                c = a-b;
                break;
                case Mode.Multiply:
                c = a*b;
                break;
                case Mode.Divide:
                c = a/b;
                break;
                default:
                // Debug.LogError("Default Value");
                break;
            }
            // Debug.LogError($"fValue {c}");
            return c;
        }
    }
}
