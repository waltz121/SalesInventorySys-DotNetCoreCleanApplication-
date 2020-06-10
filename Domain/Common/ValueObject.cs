﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public abstract class ValueObject<T>
        where T: ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected abstract bool EqualsCore(T other);

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected abstract int GetHashCodeCore();

        public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
        {
            return !(a == b);
        }
    }
}
