using System;
using System.Reflection;

namespace IntensifyingC.Classes
{
 /// <summary>
 /// 这段代码定义了一个名为DynamicallyInvokableAttribute的C#属性类，它继承自Attribute类。这个类包含三个方法：IsValidTarget、GetHashCode和Equals。
///1.IsValidTarget方法接受四个参数：targetType（目标类型）、attributeTargets（属性目标）、bindingFlags（绑定标志）和arguments（参数数组）。这个方法始终返回true，表示任何类型的目标都可以使用这个属性。
///2.GetHashCode方法返回当前对象的哈希码。由于DynamicallyInvokableAttribute类没有重写任何属性或方法，所以它的哈希码与基类的哈希码相同。
///3.Equals方法接受一个对象作为参数。如果传入的对象为null或者不是DynamicallyInvokableAttribute类型，那么这个方法返回false。否则，它会调用基类的Equals方法来比较两个对象是否相等。
///这段代码的作用是定义一个可以动态调用的属性类，但实际上并没有实现动态调用的功能。
    /// </summary>
    public class DynamicallyInvokableAttribute : Attribute
    {
        public  bool IsValidTarget(Type targetType, AttributeTargets attributeTargets, BindingFlags bindingFlags, object[] arguments)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is DynamicallyInvokableAttribute))
            {
                return false;
            }
            return base.Equals(obj);
        }
    }
}
    
