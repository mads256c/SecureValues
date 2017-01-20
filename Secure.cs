using System;

namespace mads256c.Secure
{
    static class SecureRandom {public static Random random = new Random(); }
    
    public class SecureBool
    {
        private int _value;
        private int _randomValue;

        private bool Value
        {
            get
            {
                unchecked
                {
                    if (_value - _randomValue == 0)
                        return false;
                    else
                        return true;
                }
            }

            set
            {
                unchecked
                {
                    _randomValue = SecureRandom.random.Next();
                    int i = value ? 1 : 0;
                    _value = i + _randomValue;
                }
            }
            
        }

        public SecureBool(bool value = false) => Value = value;

        public static implicit operator SecureBool(bool value) => new SecureBool(value);

        public static implicit operator bool(SecureBool value) => value.Value;

        public static bool operator == (SecureBool a, SecureBool b) => a.Value == b.Value;

        public static bool operator != (SecureBool a, SecureBool b) => a.Value != b.Value;

        public static bool operator ! (SecureBool a)
        {
            return !a.Value;
        }

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals((obj as SecureBool).Value);

    }

    public class SecureByte
    {
        private byte _value;
        private byte _randomValue;

        private byte Value
        {
            get
            {
                unchecked
                {
                    return (byte)(_value - _randomValue);
                }
            }

            set
            {
                unchecked
                {
                    _randomValue = (byte)SecureRandom.random.Next();
                    _value = (byte)(value + _randomValue);
                }
            }
        }

        public SecureByte(byte value = 0) => Value = value;

        public static implicit operator SecureByte(byte value) => new SecureByte(value);

        public static implicit operator byte(SecureByte value) => value.Value;

        public static bool operator == (SecureByte a, SecureByte b) => a.Value == b.Value;

        public static bool operator != (SecureByte a, SecureByte b) => a.Value != b.Value;

        public static SecureByte operator ++ (SecureByte a)
        {
            a.Value++;
            return a;
        }

        public static SecureByte operator -- (SecureByte a)
        {
            a.Value++;
            return a;
        }

        public static SecureByte operator + (SecureByte a, SecureByte b) => new SecureByte((byte)(a.Value + b.Value));

        public static SecureByte operator - (SecureByte a, SecureByte b) => new SecureByte((byte)(a.Value - b.Value));

        public static SecureByte operator * (SecureByte a, SecureByte b) => new SecureByte((byte)(a.Value * b.Value));

        public static SecureByte operator / (SecureByte a, SecureByte b) => new SecureByte((byte)(a.Value / b.Value));

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals((obj as SecureByte).Value);

    }

    public class SecureChar
    {
        private char _value;
        private char _randomValue;

        private char Value
        {
            get
            {
                unchecked
                {
                    return (char)(_value - _randomValue);
                }
            }

            set
            {
                unchecked
                {
                    _randomValue = (char)SecureRandom.random.Next();
                    _value = (char)(value + _randomValue);
                }
            }
        }
        public SecureChar(char value = '\x0000') => Value = value;

        public static implicit operator SecureChar(char value) => new SecureChar(value);

        public static implicit operator char(SecureChar value) => value.Value;

        public static bool operator ==(SecureChar a, SecureChar b) => a.Value == b.Value;

        public static bool operator !=(SecureChar a, SecureChar b) => a.Value != b.Value;

        public static SecureChar operator +(SecureChar a, SecureChar b) => new SecureChar((char)(a.Value + b.Value));

        public static SecureChar operator -(SecureChar a, SecureChar b) => new SecureChar((char)(a.Value - b.Value));

        public static SecureChar operator *(SecureChar a, SecureChar b) => new SecureChar((char)(a.Value * b.Value));

        public static SecureChar operator /(SecureChar a, SecureChar b) => new SecureChar((char)(a.Value / b.Value));

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals((obj as SecureChar).Value);


    }

    public class SecureDecimal
    {
        private decimal _value;
        private decimal _randomValue;

        private decimal Value
        {
            get
            {
                unchecked
                {
                    return _value - _randomValue;
                }
            }

            set
            {
                unchecked
                {
                    _randomValue = SecureRandom.random.Next(-1024, 1024);
                    _value = value + _randomValue;
                }
            }
        }

        public SecureDecimal(decimal value = 0.0m) => Value = value;

        public static implicit operator SecureDecimal(decimal value) => new SecureDecimal(value);

        public static implicit operator decimal(SecureDecimal value) => value.Value;

        public static bool operator == (SecureDecimal a, SecureDecimal b) => a.Value == b.Value;

        public static bool operator != (SecureDecimal a, SecureDecimal b) => a.Value != b.Value;

        public static SecureDecimal operator ++ (SecureDecimal a)
        {
            a.Value++;
            return a;
        }

        public static SecureDecimal operator -- (SecureDecimal a)
        {
            a.Value--;
            return a;
        }

        public static SecureDecimal operator + (SecureDecimal a, SecureDecimal b) => new SecureDecimal(a.Value + b.Value);

        public static SecureDecimal operator - (SecureDecimal a, SecureDecimal b) => new SecureDecimal(a.Value - b.Value);

        public static SecureDecimal operator * (SecureDecimal a, SecureDecimal b) => new SecureDecimal(a.Value * b.Value);

        public static SecureDecimal operator / (SecureDecimal a, SecureDecimal b) => new SecureDecimal(a.Value / b.Value);

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals((obj as SecureDecimal).Value);
    }

    public class SecureDouble
    {

        private double _value;
        private double _randomValue;

        private double Value
        {
            get
            {
                unchecked
                {
                    return _value - _randomValue;
                }
            }

            set
            {
                unchecked
                {
                    _randomValue = SecureRandom.random.Next(-1024, 1024);
                    _value = value + _randomValue;
                }
            }
        }

        public SecureDouble(double value = 0.0d) => Value = value;

        public static implicit operator SecureDouble(double value) => new SecureDouble(value);

        public static implicit operator double(SecureDouble value) => value.Value;

        public static bool operator ==(SecureDouble a, SecureDouble b) => a.Value == b.Value;

        public static bool operator !=(SecureDouble a, SecureDouble b) => a.Value != b.Value;

        public static SecureDouble operator ++(SecureDouble a)
        {
            a.Value++;
            return a;
        }

        public static SecureDouble operator --(SecureDouble a)
        {
            a.Value--;
            return a;
        }

        public static SecureDouble operator +(SecureDouble a, SecureDouble b) => new SecureDouble(a.Value + b.Value);

        public static SecureDouble operator -(SecureDouble a, SecureDouble b) => new SecureDouble(a.Value - b.Value);

        public static SecureDouble operator *(SecureDouble a, SecureDouble b) => new SecureDouble(a.Value * b.Value);

        public static SecureDouble operator /(SecureDouble a, SecureDouble b) => new SecureDouble(a.Value / b.Value);

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals((obj as SecureDouble).Value);

    }

    public class SecureFloat
    {

        private float _value;
        private float _randomValue;

        private float Value
        {
            get
            {
                unchecked
                {
                    return _value - _randomValue;
                }
            }

            set
            {
                unchecked
                {
                    _randomValue = SecureRandom.random.Next(-1024, 1024);
                    _value = value + _randomValue;
                }
            }
        }

        public SecureFloat(float value = 0.0f) => Value = value;

        public static implicit operator SecureFloat(float value) => new SecureFloat(value);

        public static implicit operator float(SecureFloat value) => value.Value;

        public static bool operator ==(SecureFloat a, SecureFloat b) => a.Value == b.Value;

        public static bool operator !=(SecureFloat a, SecureFloat b) => a.Value != b.Value;

        public static SecureFloat operator ++(SecureFloat a)
        {
            a.Value++;
            return a;
        }

        public static SecureFloat operator --(SecureFloat a)
        {
            a.Value--;
            return a;
        }

        public static SecureFloat operator +(SecureFloat a, SecureFloat b) => new SecureFloat(a.Value + b.Value);

        public static SecureFloat operator -(SecureFloat a, SecureFloat b) => new SecureFloat(a.Value - b.Value);

        public static SecureFloat operator *(SecureFloat a, SecureFloat b) => new SecureFloat(a.Value * b.Value);

        public static SecureFloat operator /(SecureFloat a, SecureFloat b) => new SecureFloat(a.Value / b.Value);

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals((obj as SecureFloat).Value);

    }

    public class SecureInt
    {

        private int _value;
        private int _randomValue;

        private int Value
        {
            get
            {
                unchecked
                {
                    return _value - _randomValue;
                }
            }

            set
            {
                unchecked
                {
                    _randomValue = SecureRandom.random.Next();
                    _value = value + _randomValue;
                }
            }
        }


        public SecureInt(int value = 0) => Value = value;

        public static implicit operator SecureInt(int value) => new SecureInt(value);

        public static implicit operator int(SecureInt value) => value.Value;

        public static bool operator == (SecureInt a, SecureInt b) => a.Value == b.Value;

        public static bool operator != (SecureInt a, SecureInt b) => a.Value != b.Value;

        public static SecureInt operator ++ (SecureInt a)
        {
            a.Value++;
            return a;
        }

        public static SecureInt operator -- (SecureInt a)
        {
            a.Value--;
            return a;
        }

        public static SecureInt operator + (SecureInt a, SecureInt b) => new SecureInt(a.Value + b.Value);

        public static SecureInt operator - (SecureInt a, SecureInt b) => new SecureInt(a.Value - b.Value);

        public static SecureInt operator * (SecureInt a, SecureInt b) => new SecureInt(a.Value * b.Value);

        public static SecureInt operator / (SecureInt a, SecureInt b) => new SecureInt(a.Value / b.Value);

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals((obj as SecureInt).Value);

    }

    public class SecureLong
    {
        private long _value;
        private long _randomValue;

        private long Value
        {
            get
            {
                unchecked
                {
                    return _value - _randomValue;
                }
            }

            set
            {
                unchecked
                {
                    _randomValue = SecureRandom.random.Next();
                    _value = value + _randomValue;
                }
            }
        }

        public SecureLong (long value = 0L) => Value = value;

        public static implicit operator SecureLong(long value) => new SecureLong(value);

        public static implicit operator long(SecureLong value) => value.Value;

        public static bool operator == (SecureLong a, SecureLong b) => a.Value == b.Value;

        public static bool operator != (SecureLong a, SecureLong b) => a.Value != b.Value;

        public static SecureLong operator ++ (SecureLong a)
        {
            a.Value++;
            return a;
        }

        public static SecureLong operator -- (SecureLong a)
        {
            a.Value--;
            return a;
        }

        public static SecureLong operator + (SecureLong a, SecureLong b) => new SecureLong(a.Value + b.Value);

        public static SecureLong operator -(SecureLong a, SecureLong b) => new SecureLong(a.Value - b.Value);

        public static SecureLong operator *(SecureLong a, SecureLong b) => new SecureLong(a.Value * b.Value);

        public static SecureLong operator /(SecureLong a, SecureLong b) => new SecureLong(a.Value / b.Value);

        public override string ToString() => Value.ToString();

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => Value.Equals((obj as SecureLong).Value);
    }


}
